using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActViewer
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            richTextBox1.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\r\n{\\*\\generator Riched20 10.0.23424}\\viewkind4\\uc1 \r\n\\pard\\sa200\\sl276\\slmult1\\f0\\fs22\\lang9 Alongside Acts of Parliament will be a coloured dot, to assist in being able to tell Acts apart by their status. Collections of documents are marked with a book, and individual documents of an Act are marked with an icon of a piece of paper. The following is a decoding table.\\par\r\nRed 'R' - Failed\\par\r\n\r\n\\pard\\li720\\sa200\\sl276\\slmult1 This indicates a Bill which failed three readings, or was not fully read by the end of the session.\\par\r\n\r\n\\pard\\sa200\\sl276\\slmult1 Orange 'D' - Destroyed\\par\r\n\r\n\\pard\\li720\\sa200\\sl276\\slmult1 This indicates an Act which has been lost after a data loss incident. They are considered repealed.\\par\r\n\r\n\\pard\\sa200\\sl276\\slmult1 Yellow 'P' - Pending\\par\r\n\r\n\\pard\\li720\\sa200\\sl276\\slmult1 This indicates a Bill that is currently in the process of parliamentary approval or Royal Assent.\\par\r\n\r\n\\pard\\sa200\\sl276\\slmult1 Green 'IF' - In force\\par\r\n\r\n\\pard\\li720\\sa200\\sl276\\slmult1 This indicates an Act that is in force, as originally enacted.\\par\r\n\r\n\\pard\\sa200\\sl276\\slmult1 Blue 'S' - Spent\\par\r\n\r\n\\pard\\li720\\sa200\\sl276\\slmult1 This indicates an Act which has served the purpose for which the Act was enacted.\\par\r\n\r\n\\pard\\sa200\\sl276\\slmult1 Purple 'A' - Amended\\par\r\n\r\n\\pard\\li720\\sa200\\sl276\\slmult1 This indicates an Act that is in force, with amendments made to it.\\par\r\n\r\n\\pard\\sa200\\sl276\\slmult1 Black 'R' - Repealed\\par\r\n\r\n\\pard\\li720\\sa200\\sl276\\slmult1 This indicates an Act that is no longer in force.\\par\r\n}\r\n ";
            richTextBox2.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1033\r\n{\\*\\generator Riched20 10.0.23424}\\viewkind4\\uc1 \r\n\\pard\\sa200\\sl276\\slmult1\\f0\\fs22\\lang9 Each entry of an Act of Parliament is highlighted by a colour. This colour represents the originating party or entity.\\par\r\n\r\n\\pard\\li720\\sa200\\sl276\\slmult1 Red refers to the Communist Party of Baustralia (formerly Worker's Party of Baustralia),\\par\r\nGreen refers to the Liberal Party of Baustralia (formerly Grand Union of Leftist Parties),\\par\r\nBlue refers to the Conservative Party of Baustralia,\\par\r\nPurple refers to the Sovereign, in accordance with the \\i Monarchy (Powers) Act, 3 John 1 c. 14\\i0 .\\par\r\n\r\n\\pard\\sa200\\sl276\\slmult1 Acts of Parliament which have been destroyed are marked in black.\\par\r\n}\r\n";
        }
    }
}
