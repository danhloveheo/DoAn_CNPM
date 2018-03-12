using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LTDM.Global
{
    
    public static class Finger
    {
        public static List<string> Left_NgonUt = new List<string> { "`", "1", "Tab", "q", "Caps", "a", "Shift_Left", "z", "Ctrl_Left" };
        public static List<string> Left_NgonApUt = new List<string> { "@", "2", "w", "s", "x" };
        public static List<string> Left_NgonGiua = new List<string> { "#", "3", "e", "d", "c" };
        public static List<string> Left_NgonTro = new List<string> { "4", "5", "r", "t", "f", "g", "v", "b" };
        public static List<string> NgonCai = new List<string> { "Fn_Left", "Alt_Left", "_", "Alt_Right", "Fn_Right", " " };
        public static List<string> Right_NgonUt = new List<string> { ")", "0", "_", "-", "+", "=", "Back", "p", "{", "[", "}", "]", "|", "\\", ":", ";", "\"", "'", "Enter", "?", "/", "Shift_Right", "Ctrl_Right" };
        public static List<string> Right_NgonApUt = new List<string> { "(", "9", "o", "l", ">", "." };
        public static List<string> Right_NgonGiua = new List<string> { "*", "8", "i", "k", ",","<" };
        public static List<string> Right_NgonTro = new List<string> { "^", "&", "6", "7", "y", "u", "h", "j", "n", "m" };


        public static List<string> NgonTro = new List<string> { "4", "5", "r", "t", "f", "g", "v", "b", "6", "7", "y", "u", "h", "j", "n", "m" };
        public static List<string> NgonTro_NgonGiua = new List<string> { "4", "e", "d", "c", "8", "i", "k", ",", "5", "r", "t", "f", "g", "v", "b", "6", "7", "y", "u", "h", "j", "n", "m", "3" };
        public static List<string> NgonTro_NgonGiua_ApUt = new List<string> { "4", "5", "r", "t", "f", "g", "v", "b", "6", "7", "y", "u", "h", "j", "n", "m", "3", "e", "d", "c", "8", "i", "k", ",", "2", "w", "s", "x", "9", "o", "l", "." };
        public static List<string> NgonTro_NgonGiua_ApUt_Ut = new List<string> { "4", "5", "r", "t", "f", "g", "v", "b", "6", "7", "y", "u", "h", "j", "n", "m", "3", "e", "d", "c", "8", "i", "k", ",", "2", "w", "s", "x", "9", "o", "l", ".", "1", "q", "a", "z", "0", "-", "=", "p", "[", "]", ";", "'", "/" };
        public static List<string> NgonTro_NgonGiua_ApUt_Ut_Cai = new List<string> { "4", "5", "r", "t", "f", "g", "v", "b", "6", "7", "y", "u", "h", "j", "n", "m", "3", "e", "d", "c", "8", "i", "k", ",", "2", "w", "s", "x", "9", "o", "l", ".", "1", "q", "a", "z", "0", "-", "=", "p", "[", "]", ";", "'", "/", " " };
    }
}
