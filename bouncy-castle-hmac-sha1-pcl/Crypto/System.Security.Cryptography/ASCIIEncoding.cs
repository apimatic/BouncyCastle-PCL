﻿/***********************************************************************************************
* This license is an adaptation of the MIT X11 (http://opensource.org/licenses/mit-license.php) 
* License and should be read as such.
* 
* LICENSE
* Copyright (c) 2000 - 2011 The Legion of the Bouncy Castle Inc. (http://www.bouncycastle.org)
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy of this software
* and associated documentation files (the "Software"), to deal in the Software without
* restriction, including without limitation the rights to use, copy, modify, merge, publish,
* distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the
* Software is furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in all copies or
* substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING
* BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
* NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
* DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 **********************************************************************************************/

namespace System.Text
{
    /// <summary>
    /// Silverlight doesn't have an ASCII encoder, so here is one:
    /// </summary>
    public class ASCIIEncoding : System.Text.Encoding
    {
        public static ASCIIEncoding ASCII = new ASCIIEncoding();

        public override int GetMaxByteCount(int charCount)
        {
            return charCount;
        }
        public override int GetMaxCharCount(int byteCount)
        {
            return byteCount;
        }
        public override int GetByteCount(char[] chars, int index, int count)
        {
            return count;
        }
        public override byte[] GetBytes(char[] chars)
        {
            return base.GetBytes(chars);
        }
        public override int GetCharCount(byte[] bytes)
        {
            return bytes.Length;
        }
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
            for (int i = 0; i < charCount; i++)
            {
                bytes[byteIndex + i] = (byte)chars[charIndex + i];
            }
            return charCount;
        }
        public override int GetCharCount(byte[] bytes, int index, int count)
        {
            return count;
        }
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
        {
            for (int i = 0; i < byteCount; i++)
            {
                chars[charIndex + i] = (char)bytes[byteIndex + i];
            }
            return byteCount;
        }
    }
}
