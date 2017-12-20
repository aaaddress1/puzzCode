using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace puzzCode
{
    public static class obfuscator
    {
        public static RichTextBox logText;
        private static void logMsg(string text, Color colorReq, string endchar = "\n")
        {
            Program.mainUi.BeginInvoke((MethodInvoker)delegate
            {
                Color org = logText.SelectionColor;
                logText.SelectionColor = colorReq;
                logText.AppendText(text + endchar);
                logText.SelectionColor = org;
                logText.ScrollToCaret();
            });
        }

        private static int label_extra_count = 0;
        private static int junk_count = 0;
        private static int obfuscat_code_count = 0;
        private static Random rnd = new Random();
        private static bool shouldGeneratJunk()
        {
            return (rnd.Next(0, 100) < Properties.Settings.Default.obfusPcnt);
        }

        private static void randJunk(ref string currLineAddition, ref string extraCodeAddition, bool forceJunk = false)
        {
            if (!shouldGeneratJunk() && !forceJunk) return;
            junk_count++;
            switch (rnd.Next(0, 5))
            {
                case 2:
                    currLineAddition = "lea esp, [esp-8]\n" +
                                        "mov dword ptr [esp+4], offset obfusca_" + label_extra_count + "\n" +
                                        "mov dword ptr [esp+0], offset obfusca_" + (label_extra_count + 1) + "\n" +
                                        "ret\n" +
                                        "obfusca_" + label_extra_count + ":\n";

                    extraCodeAddition = "obfusca_" + (label_extra_count + 1) + ":\n" +
                                        "lea esp, [esp+4]\n" +
                                        "jmp dword ptr [esp-4]\n" +
                                        "int 3\n";

                    label_extra_count += 2;
                    break;

                case 3:
                    currLineAddition = "push eax\n" +
                                        "lea esp, [esp-8]\n" +
                                        "mov dword ptr [esp+0], offset obfusca_" + label_extra_count + "\n" +
                                        "mov dword ptr [esp+4], offset obfusca_" + (label_extra_count + 1) + "\n" +
                                        "mov eax, [esp+4]\n" +
                                        "xchg eax, [esp+0]\n" +
                                        "mov [esp+4], eax\n" +
                                        "ret\n" +
                                        "obfusca_" + label_extra_count + ":\n" +
                                        "pop eax\n";

                    extraCodeAddition = "obfusca_" + (label_extra_count + 1) + ":\n" +
                                        "lea esp, [esp+4]\n" +
                                        "jmp dword ptr [esp-4]\n" +
                                        "int 3\n";

                    label_extra_count += 2;
                    break;

                case 0:
                    currLineAddition = "pushf\n" +
                     "sub esp, 5\nlea esp, [esp-3]\n" +
                     "mov dword ptr [esp+4], offset obfusca_" + label_extra_count + "\n" +
                     "mov dword ptr [esp+0], offset obfusca_" + (label_extra_count + 1) + "\n" +
                     "jmp dword ptr [esp+0]\n" +
                     "obfusca_" + label_extra_count + ":\n";

                    extraCodeAddition = "obfusca_" + (label_extra_count + 1) + ":\n" +
                                        "lea esp, [esp+8]\n" +
                                        "popf\n" +
                                        "jmp dword ptr [esp-8]\n" +
                                        "int 3\n";

                    label_extra_count += 2;
                    break;
                case 1:
                    currLineAddition = "push offset obfusca_" + label_extra_count + "\n" +
                                        "push offset obfusca_" + (label_extra_count + 1) + "\n" +
                                        "ret\n" +
                                        "obfusca_" + label_extra_count + ":\n";

                    extraCodeAddition = "obfusca_" + (label_extra_count + 1) + ":\n" +
                                        "ret\n" +
                                        "int 3\n";

                    label_extra_count += 2;
                    break;
                default:
                    currLineAddition = "pushf\nxor edi, esi\nxor edi, esi\npopf\nnop\n";
                    extraCodeAddition = "int 0x2e\n";
                    break;
            }
        }
        private static void obfuscatCode(string orginalCode, ref string currLineAddition, ref string extraCodeAddition, bool forceJunk = false)
        {
            currLineAddition = orginalCode + "\r\n";
            extraCodeAddition = "";
            if (!shouldGeneratJunk() && !forceJunk) return;

            obfuscat_code_count++;
            Match m = new Regex(@"mov[\x20\t]+([^,]+),(.+)").Match(orginalCode);
            if (m.Success)
            {
                currLineAddition = string.Format(
                    "push {1}           \r\n" +
                    "call obfusca_{2}   \r\n" +
                    "pop {0}            \r\n",
                    m.Groups[1].Value, m.Groups[2].Value, label_extra_count
                    );

                extraCodeAddition = string.Format(
                    "obfusca_{0}:       \r\n" +
                    "pushf              \r\n" +
                    "push ecx           \r\n" +
                    "mov ecx, {2}      \r\n" +
                    "obfusca_{1}:       \r\n" +
                    "loop obfusca_{1}   \r\n" +
                    "pop ecx            \r\n" +
                    "popf               \r\n" +
                    "ret                \r\n", label_extra_count, label_extra_count+1, rnd.Next(5, 128)
                    );
                    label_extra_count += 2;
                return;
            }

            m = new Regex(@"call[\x20\t]+(.+)").Match(orginalCode);
            if (m.Success)
            {
                currLineAddition = string.Format(
                    "push offset obfusca_{1}         \r\n" +
                    "push offset {0}                        \r\n" +
                    "ret                             \r\n" +
                    "obfusca_{1}:",
                    m.Groups[1].Value, label_extra_count
                    );
                extraCodeAddition = "";
                label_extra_count += 1;
                return;
            }

            currLineAddition = string.Format(
                "obfusca_{1}:       \r\n" +
                "call obfusca_{2}   \r\n" +
                "loop obfusca_{1}    \r\n" +
                "obfusca_{2}:       \r\n" +
                "call obfusca_{3}    \r\n"+
                "loop obfusca_{1}   \r\n" +
                "obfusca_{3}:       \r\n" +
                "call obfusca_{4}   \r\n" +
                "loop obfusca_{2}   \r\n" +
                "obfusca_{4}:       \r\n" +
                "lea esp, [esp+12]  \r\n" +
                "{0}                \r\n",
                orginalCode, label_extra_count, label_extra_count + 1, label_extra_count + 2, label_extra_count + 3
                );
            label_extra_count += 4;

        }
        public static bool obfuscaAsm(string asmPath, string outObfAsmPath)
        {
            label_extra_count = 0;
            junk_count = 0;
            obfuscat_code_count = 0;

            string asmCode = System.IO.File.ReadAllText(asmPath);

            string[] gadgets = asmCode.Split('\n');
            string fixCode = "";
            string extCode = ".section	.text$junk,\x22wx\x22\n";

            string currFuncNameMatch = "";
            for (int i = 0; i < gadgets.Length; i++)
            {
                Program.mainUi.BeginInvoke((MethodInvoker)delegate () { Program.mainUi.percntLB.Text = (i * 100 / gadgets.Length) + "%"; });
                var currLine = gadgets[i];

                Match m = new Regex(@"(.+):\r").Match(gadgets[i]);
                if (m.Success && i < gadgets.Length - 2)
                {
                    currFuncNameMatch = m.Groups[1].Value;
                    if (gadgets[i + 2].Contains("cfi_startproc"))
                    {
                        logMsg("found func::" + currFuncNameMatch + "() at #" + i, Color.Blue);
                        fixCode += gadgets[i] + "\n\r" + gadgets[i + 1] + "\n\r" + gadgets[i + 2] + "\n\r";
                        i += 2;
                        continue;
                    }
                    else currFuncNameMatch = "";
                }

                if (currFuncNameMatch != "")
                {
                    string getJunk = "", getExtra = "";
                    if (Properties.Settings.Default.cnfseCode)
                    {
                        obfuscatCode(gadgets[i], ref getJunk, ref getExtra);
                        fixCode += getJunk;
                        extCode += getExtra;
                    }
                    else
                        fixCode += gadgets[i] + "\n\r";

                    getJunk = ""; getExtra = "";
                    if (Properties.Settings.Default.insrtJunk)
                    {
                        randJunk(ref getJunk, ref getExtra);
                        fixCode += getJunk;
                        extCode += getExtra;
                        if (gadgets[i].Contains("cfi_endproc")) currFuncNameMatch = "";
                    }
                }
                else
                    fixCode += gadgets[i] + "\n\r";
            }
            Program.mainUi.BeginInvoke((MethodInvoker)delegate () { Program.mainUi.percntLB.Text = "100%"; });
            logMsg(string.Format(
                "[\tOK\t] obfuscate result:         \n" +
                " - generate {0} junk codes         \n" +
                " - generate {1} obfuscated codes   \n" +
                " - generate {2} function pieces    \n", junk_count, obfuscat_code_count, label_extra_count), Color.Green);

            System.IO.File.WriteAllText(outObfAsmPath, fixCode + "\n" + extCode);
            return true;
        }

    }
}
