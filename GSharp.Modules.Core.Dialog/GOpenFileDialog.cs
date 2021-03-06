﻿using System.Windows.Forms;
using GSharp.Extension.Abstracts;
using GSharp.Extension.Attributes;

namespace GSharp.Modules.Core.Dialog
{
    public class GOpenFileDialog : GModule
    {
        [GCommand("열기 선택기로 선택한 파일")]
        public static string ShowDialog
        {
            get
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    return fileDialog.FileName;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
