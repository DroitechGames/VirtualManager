using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace VirtualManager
{
    public struct VirtualCommander
    {
        public class MachineManager
        {
            public static Process _VirtualBoxManagerProcess = new Process();
            private static string _VirtualBoxManagerPathWOW64 = "C:\\Program Files\\Oracle\\VirtualBox\\VBoxManage.exe";
            private static string _VirtualBoxManagerPathWOW32 = "C:\\Program Files (x86)\\Oracle\\VirtualBox\\VBoxManage.exe";
            private static bool _VirtualBoxManagerCommandCompleted = false;
            private static string _VirtualBoxManagerProcessVerb = "runas";
            private static string _VirtualBoxManagerProcessArgument = "";
            public static string[] _VirtualBoxManagerCommandArray = new string[46]; // 45 Commands exist in the VBoxManage.exe
            private static int _Counter;      
            private static string[] _VBOX_POPULATE_COMMAND_ARRAY(string[] _xArray)
            {
                _xArray[0] = "null";
                _xArray[1] = "list";
                _xArray[2] = "showvminfo";
                _xArray[3] = "registervm";
                _xArray[4] = "unregistervm";
                _xArray[5] = "createvm";
                _xArray[6] = "modifyvm";
                _xArray[7] = "movevm";
                _xArray[8] = "import";
                _xArray[9] = "export";
                _xArray[10] = "startvm";
                _xArray[11] = "controlvm";
                _xArray[12] = "discardstate";
                _xArray[13] = "adoptstate";
                _xArray[14] = "closemedium";
                _xArray[15] = "storageattach";
                _xArray[16] = "storagectl";
                _xArray[17] = "bandwidthctl";
                _xArray[18] = "showmediuminfo";
                _xArray[19] = "createmedium";
                _xArray[20] = "modifymedium";
                _xArray[21] = "clonemedium";
                _xArray[22] = "mediumproperty";
                _xArray[23] = "encryptmedium";
                _xArray[24] = "checkmediumpwd";
                _xArray[25] = "convertfromraw";
                _xArray[26] = "getextradata";
                _xArray[27] = "setextradata";
                _xArray[28] = "setproperty";
                _xArray[29] = "usbfilter";
                _xArray[30] = "sharedfolder";
                _xArray[31] = "guestproperty";
                _xArray[32] = "guestcontrol";
                _xArray[33] = "metrics";
                _xArray[34] = "natnetwork";
                _xArray[35] = "hostonlyif";
                _xArray[36] = "usbdevsource";
                _xArray[37] = "snapshot";
                _xArray[38] = "clonevm";
                _xArray[39] = "mediumio";
                _xArray[40] = "dhcpserver";
                _xArray[41] = "debugvm";
                _xArray[42] = "extpack";
                _xArray[43] = "unattended";
                _xArray[44] = "cloudprofile";
                _xArray[45] = "cloud";

                // return filled array....

                return _xArray;
            }
            public static string _VBOX_RUN_COMMAND(int _CommandSelectionID, string[] _VirtualBoxCommandArray, string _VirtualBoxCommandLine)
            {
                _VBOX_POPULATE_COMMAND_ARRAY(_VirtualBoxCommandArray); // populate the command args.
                foreach (string Item in _VirtualBoxCommandArray)
                {
                    _Counter ++  ; // count each item in the command array.
                    if (_CommandSelectionID == 0)
                    {
                        
                    }
                    if (_Counter == _CommandSelectionID)
                    {
                        // run the command if the counter is equal to the command selection ID, basically if the selection ID exists.
                        MessageBox.Show("You have selected: " + _VirtualBoxCommandArray[_CommandSelectionID]+" : " + _VirtualBoxCommandLine);
                        //return "";
                    }
                    else if (_Counter == 2)
                    {

                    }
                    else if (_Counter == 3)
                    {

                    }
                    else if (_Counter == 4)
                    {

                    }
                   
                }
                return "Error. The Selected Command ID doesnt exist.";
            }
            private static string _VBOX_GET_COMMAND_SELECTION(int _SelectionID, string[] _xArray)
            {
                string _SelectedCommand;
                _SelectedCommand = _xArray[_SelectionID];
                return _SelectedCommand.ToString();
            }
        }
    }
}
