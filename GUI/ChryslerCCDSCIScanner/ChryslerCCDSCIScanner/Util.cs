﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChryslerCCDSCIScanner
{
    public static class Util
    {
        public static string ByteToHexString(byte[] data, int offset, int count)
        {
            StringBuilder ret = new StringBuilder();
            byte counter = 0;

            if (data != null)
            {
                for (int i = offset; i < count; i++)
                {
                    if (count < 17) ret.Append(Convert.ToString(data[i], 16).PadLeft(2, '0').PadRight(3, ' ').ToUpper());
                    else
                    {
                        ret.Append(Convert.ToString(data[i], 16).PadLeft(2, '0').PadRight(3, ' ').ToUpper());

                        counter++;
                        if (counter > 15)
                        {
                            ret.Append(Environment.NewLine); // New line after every 16 bytes
                            counter = 0;
                        }
                    }
                }
                ret.Replace(" ", String.Empty, ret.Length - 1, 1); // remove whitespace at the end caused by PadRight(3, ' ')
            }
            return ret.ToString();
        }

        public static byte[] HexStringToByte(string str)
        {
            // Remove whitespaces, commas, semi-colons and hex number identifiers
            string ret = str.Trim().Replace(" ", String.Empty).Replace(",", String.Empty).Replace(";", String.Empty).Replace("$", String.Empty).Replace("0x", String.Empty);
            try
            {
                return Enumerable.Range(0, ret.Length).Where(x => x % 2 == 0).Select(x => Convert.ToByte(ret.Substring(x, 2), 16)).ToArray();
            }
            catch
            {
                return new byte[] { 0x00 }; // return a zero byte if something is wrong
            }
        }

        public static void UpdateTextBox(TextBox textbox, string text, byte[] bytes)
        {
            string ret = String.Empty;

            if (textbox.Text != "") ret += Environment.NewLine + Environment.NewLine;
            ret += text;
            if (bytes != null) ret += Environment.NewLine + ByteToHexString(bytes, 0, bytes.Length);

            if (MainForm.USBShowTraffic)
            {
                if (textbox.InvokeRequired)
                {
                    textbox.Invoke((MethodInvoker)delegate
                    {
                        if (textbox.TextLength + text.Length > textbox.MaxLength)
                        {
                            textbox.Clear();
                            GC.Collect();
                        }
                        textbox.AppendText(ret);
                    });
                }
                else
                {
                    if (textbox.TextLength + text.Length > textbox.MaxLength)
                    {
                        textbox.Clear();
                        GC.Collect();
                    }
                    textbox.AppendText(ret);
                }
            }

            // Save text to a logfile
            if (textbox.Name == "USBTextBox") File.AppendAllText(MainForm.USBLogFilename, ret);
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}