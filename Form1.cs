using ActViewer.Properties;
using Squirrel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ActViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static async Task UpdateApp(ToolStripSplitButton btn)
        {
            using var mgr = new UpdateManager("https://baustralia.ca/ActViewer/app/");
            var newVersion = await mgr.UpdateApp();

            // optionally restart the app automatically, or ask the user if/when they want to restart
            if (newVersion != null)
            {
                btn.Image = Resources.updates;
                UpdateManager.RestartApp();
            }
            btn.Image = Resources.noupdates;
        }

        string[] formats =
               {"The {0} chapter of the Statute of Parliament that sat during the {1} Year of the Reign of King John, {2}.",
                 "Statute information",
                 "{0} c. {1}. Status: {2}",
                 "The {0} chapter of the Statute of Parliament that sat during the {1} Year of the Reign of King John.",
                 "\r\nThis chapter has been destroyed and shall be considered spent.",
                 "\r\nDestroyed and recreated from recovered information.\r\nVote counts and introductory information unavaliable."
                };

        string helpFilePath = String.Empty;

        TreeView defTree = new TreeView();

        private void getFrom(string selector)
        {
            switch (selector.ToLower())
            {
                #region 1 John 1
                case "1john1":
                    longCitation.Text = formats[1];
                    displayTextBox.SelectedText = "1 John 1\r\n\r\n20 June 2017-19 June 2018\r\n\r\nFirst Timpson ministry (Conservative, 3/3)\r\n\r\n3 Acts of Parliament";
                    selectionLabel.Text = "1 John 1";
                    break;
                #region Chapter 1
                case "1john1c1original":
                    formGen(1, "John 1", 1, "Repealed");
                    displayTextBox.SelectedText = Resources._1john1_1_original;
                    break;
                case "1john1c1":
                    formGen(1, "John 1", 1, "Repealed");
                    displayTextBox.SelectedText = "Bill of Rights, Constitution and Justice Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nRepealed by 2 John 1 c. 1 (Repeal Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 2
                case "1john1c2original":
                    formGen(2, "John 1", 1, "Repealed", new figures_1john1c2());
                    displayTextBox.SelectedText = Resources._1john1_2_original;
                    break;
                case "1john1c2":
                    formGen(2, "John 1", 1, "Repealed");
                    displayTextBox.SelectedText = "National Symbols Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nRepealed by 2 John 1 c. 1 (Repeal Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 3
                case "1john1c3amend1":
                    displayTextBox.SelectedText = Resources._1john1_3_amend1;
                    formGen(3, "John 1", 1, "Repealed");
                    break;
                case "1john1c3original":
                    displayTextBox.SelectedText = Resources._1john1_3_original;
                    formGen(3, "John 1", 1, "Repealed");
                    break;
                case "1john1c3":
                    formGen(3, "John 1", 1, "Repealed");
                    displayTextBox.SelectedText = "Succession Law (Modifications) Act\r\nBy command of the Sovereign.\r\nRepealed by 2 John 1 c. 1 (Repeal Act).\r\nAmended by 4 John 1 c. 18 (Citation (Succession Law) Act).";
                    break;
                #endregion
                #endregion
                #region 2 John 1
                case "2john1":
                    longCitation.Text = formats[1];
                    displayTextBox.SelectedText = "2 John 1\r\n\r\n20 June 2018-19 June 2019\r\n\r\nFirst Timpson ministry (30/30)\r\n\r\n30 Acts of Parliament";
                    selectionLabel.Text = "2 John 1";
                    break;
                #region Chapter 1
                case "2john1c1original":
                    formGen(1, "John 1", 2, "Spent");
                    displayTextBox.SelectedText = Resources._2john1_1_original;
                    break;
                case "2john1c1":
                    formGen(1, "John 1", 2, "Spent");
                    displayTextBox.SelectedText = "Repeal Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nRepeals:\r\n  1 John 1 c. 1\r\n  1 John 1 c. 2\r\n  1 John 1 c. 3\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 2
                case "2john1c2original":
                    formGen(2, "John 1", 2, "Amended");
                    displayTextBox.SelectedText = Resources._2john1_2_original;
                    break;
                case "2john1c2amend1":
                    formGen(2, "John 1", 2, "Amended");
                    displayTextBox.SelectedText = Resources._2john1_2_amend1;
                    break;
                case "2john1c2amend2":
                    formGen(2, "John 1", 2, "Amended");
                    displayTextBox.SelectedText = Resources._2john1_2_amend2;
                    break;
                case "2john1c2amend3":
                    formGen(2, "John 1", 2, "Amended");
                    displayTextBox.SelectedText = Resources._2john1_2_amend3;
                    break;
                case "2john1c2amend4":
                    formGen(2, "John 1", 2, "Amended");
                    displayTextBox.SelectedText = Resources._2john1_2_amend4;
                    break;
                case "2john1c2":
                    formGen(2, "John 1", 2, "Amended");
                    displayTextBox.SelectedText = "Constitution Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nAmended by:\r\n  2 John 1 c. 11 (Succession Law (Modifications, No. 2) Act).\r\n  2 John 1 c. 27 (Fixed Terms Election Act).\r\n  3 John 1 c. 40 (Oaths Act).\r\n  4 John 1 c. 50 (Oaths Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 3
                case "2john1c3original":
                    displayTextBox.SelectedText = Resources._2john1_3_original;
                    formGen(3, "John 1", 2, "In force", new figures_2john1c3());
                    break;
                case "2john1c3":
                    formGen(3, "John 1", 2, "In force");
                    displayTextBox.SelectedText = "National Symbols Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 4
                case "2john1c4amend1":
                    displayTextBox.SelectedText = Resources._2john1_4_amend1;
                    formGen(4, "John 1", 2, "Repealed");
                    break;
                case "2john1c4original":
                    displayTextBox.SelectedText = Resources._2john1_4_original;
                    formGen(4, "John 1", 2, "Repealed");
                    break;
                case "2john1c4":
                    displayTextBox.SelectedText = "Succession Law (Modifications) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nRepealed by 2 John 1 c. 11 (Succession Law (Modifications, No. 2) Act)\r\nAmended by 3 John 1 c. 8 (Short Titles Act).\r\nNo vote counts avaliable.";
                    formGen(4, "John 1", 2, "Repealed");
                    break;
                #endregion
                #region Chapter 5
                case "2john1c5original":
                    displayTextBox.SelectedText = Resources._2john1_5_original;
                    formGen(5, "John 1", 2, "Spent");
                    break;
                case "2john1c5":
                    displayTextBox.SelectedText = "Army Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    formGen(5, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 6
                case "2john1c6original":
                    displayTextBox.SelectedText = Resources._2john1_6_original;
                    formGen(6, "John 1", 2, "Repealed");
                    break;
                case "2john1c6":
                    displayTextBox.SelectedText = "Air Force Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nRepealed by 2 John 1 c. 15 (Air Force (No. 2) Act.\r\nNo vote counts avaliable.";
                    formGen(6, "John 1", 2, "Repealed");
                    break;
                #endregion
                #region Chapter 7
                case "2john1c7original":
                    displayTextBox.SelectedText = Resources._2john1_7_original;
                    formGen(7, "John 1", 2, "In force", new figures_2john1c7());
                    break;
                case "2john1c7":
                    displayTextBox.SelectedText = "Orders, medals, and decorations of Baustralia Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    formGen(7, "John 1", 2, "In force");
                    break;
                #endregion
                #region Chapter 8
                case "2john1c8original":
                    displayTextBox.SelectedText = Resources._2john1_8_original;
                    formGen(8, "John 1", 2, "Repealed");
                    break;
                case "2john1c8":
                    displayTextBox.SelectedText = "Cannabis Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nRepealed by 3 John 1 c. 1 (Cannabis Act (Legalization)).\r\nNo vote counts avaliable.";
                    formGen(8, "John 1", 2, "Repealed");
                    break;
                #endregion
                #region Chapter 9
                case "2john1c9original":
                    displayTextBox.SelectedText = Resources._2john1_9_original;
                    formGen(9, "John 1", 2, "Spent");
                    break;
                case "2john1c9":
                    displayTextBox.SelectedText = "Dukedom of Northumbria Act\r\nBy command of the Sovereign.";
                    formGen(9, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 10
                case "2john1c10original":
                    displayTextBox.SelectedText = Resources._2john1_10_original;
                    formGen(10, "John 1", 2, "Spent");
                    break;
                case "2john1c10":
                    displayTextBox.SelectedText = "Fox Islands Act\r\nIntroduced by the Minister of Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    formGen(10, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 11
                case "2john1c11amend1":
                    displayTextBox.SelectedText = Resources._2john1_11_amend1;
                    formGen(11, "John 1", 2, "Repealed");
                    break;
                case "2john1c11original":
                    displayTextBox.SelectedText = Resources._2john1_11_original;
                    formGen(11, "John 1", 2, "Repealed");
                    break;
                case "2john1c11":
                    displayTextBox.SelectedText = "Succession Law (Modifications, No. 2) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nRepeals 2 John 1 c. 4.\r\nAmends 2 John 1 c. 2.\r\nAmended by 3 John 1 c. 8 (Short Titles Act).\r\nRepealed by 6 John 1 c. 18 (Succession Law (Modifications, No. 1) Act).\r\nNo vote counts avaliable.";
                    formGen(11, "John 1", 2, "Repealed");
                    break;
                #endregion
                #region Chapter 12
                case "2john1c12original":
                    displayTextBox.SelectedText = Resources._2john1_12_original;
                    formGen(12, "John 1", 2, "Repealed");
                    break;
                case "2john1c12":
                    displayTextBox.SelectedText = "Citizenship Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nRepealed by 3 John 1 c. 105 (Citizenship Act)\r\nNo vote counts avaliable.";
                    formGen(12, "John 1", 2, "Repealed");
                    break;
                #endregion
                #region Chapter 13
                case "2john1c13original":
                    displayTextBox.SelectedText = Resources._2john1_13_original;
                    formGen(13, "John 1", 2, "Spent");
                    break;
                case "2john1c13":
                    displayTextBox.SelectedText = "Kapreburg Act\r\nIntroduced by the Minister for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    formGen(13, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 14
                case "2john1c14original":
                    displayTextBox.SelectedText = Resources._2john1_14_original;
                    formGen(14, "John 1", 2, "Spent");
                    break;
                case "2john1c14":
                    displayTextBox.SelectedText = "Rmhoania Act\r\nIntroduced by the Minister for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    formGen(14, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 15
                case "2john1c15original":
                    displayTextBox.SelectedText = Resources._2john1_15_original;
                    formGen(15, "John 1", 2, "Spent");
                    break;
                case "2john1c15":
                    displayTextBox.SelectedText = "Air Force (No. 2) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nRepeals 2 John 1 c. 6.\r\nAmended by 3 John 1 c. 44 (Short Titles (No. 2) Act.\r\nNo vote counts avaliable.";
                    formGen(15, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 16
                case "2john1c16original":
                    displayTextBox.SelectedText = Resources._2john1_16_original;
                    formGen(16, "John 1", 2, "Amended");
                    break;
                case "2john1c16amend1":
                    displayTextBox.SelectedText = Resources._2john1_16_amend1;
                    formGen(16, "John 1", 2, "Amended");
                    break;
                case "2john1c16":
                    displayTextBox.SelectedText = "Religion (Throne) Act\r\nBy command of the Sovereign.\r\nAmended by 2 John 1 c. 24 (Religion (Practice) Act).\r\nNo vote counts avaliable.";
                    formGen(16, "John 1", 2, "Amended");
                    break;
                #endregion
                #region Chapter 17
                case "2john1c17original":
                    displayTextBox.SelectedText = Resources._2john1_17_original;
                    formGen(17, "John 1", 2, "In force");
                    break;
                case "2john1c17":
                    displayTextBox.SelectedText = "Seperation Act\r\nBy command of the Sovereign.\r\nNo vote counts avaliable.";
                    formGen(17, "John 1", 2, "In force");
                    break;
                #endregion
                #region Chapter 18
                case "2john1c18original":
                    displayTextBox.SelectedText = Resources._2john1_18_original;
                    formGen(18, "John 1", 2, "Spent");
                    break;
                case "2john1c18":
                    displayTextBox.SelectedText = "Abdication Act\r\nBy command of the Sovereign.\r\nNo vote counts avaliable.";
                    formGen(18, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 19
                case "2john1c19original":
                    displayTextBox.SelectedText = Resources._2john1_19_original;
                    formGen(19, "John 1", 2, "In force");
                    break;
                case "2john1c19":
                    displayTextBox.SelectedText = "Boerc Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    formGen(19, "John 1", 2, "In force");
                    break;
                #endregion
                #region Chapter 20
                case "2john1c20original":
                    displayTextBox.SelectedText = Resources._2john1_20_original;
                    formGen(20, "John 1", 2, "In force");
                    break;
                case "2john1c20":
                    displayTextBox.SelectedText = "Counterfeit Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    formGen(20, "John 1", 2, "In force");
                    break;
                #endregion
                #region Chapter 21
                case "2john1c21original":
                    displayTextBox.SelectedText = Resources._2john1_21_original;
                    formGen(21, "John 1", 2, "Repealed");
                    break;
                case "2john1c21":
                    displayTextBox.SelectedText = "Boerc Measures Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nRepealed by 3 John 1 c. 43 (Boerc Measures Act).\r\nNo vote counts avaliable.";
                    formGen(21, "John 1", 2, "Repealed");
                    break;
                #endregion
                #region Chapter 22
                case "2john1c22original":
                    displayTextBox.SelectedText = Resources._2john1_22_original;
                    formGen(22, "John 1", 2, "In force");
                    break;
                case "2john1c22":
                    displayTextBox.SelectedText = "War Powers Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    formGen(22, "John 1", 2, "In force");
                    break;
                #endregion
                #region Chapter 23
                case "2john1c23original":
                    displayTextBox.SelectedText = Resources._2john1_23_original;
                    formGen(23, "John 1", 2, "In force");
                    break;
                case "2john1c23":
                    displayTextBox.SelectedText = "Treason Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    formGen(23, "John 1", 2, "In force");
                    break;
                #endregion
                #region Chapter 24
                case "2john1c24original":
                    displayTextBox.SelectedText = Resources._2john1_24_original;
                    formGen(24, "John 1", 2, "In force");
                    break;
                case "2john1c24":
                    displayTextBox.SelectedText = "Religion (Practice) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nAmends 2 John 1 c. 16.\r\nNo vote counts avaliable.";
                    formGen(24, "John 1", 2, "In force");
                    break;
                #endregion
                #region Chapter 25
                case "2john1c25original":
                    displayTextBox.SelectedText = Resources._2john1_25_original;
                    formGen(25, "John 1", 2, "Spent");
                    break;
                case "2john1c25":
                    displayTextBox.SelectedText = "Marines Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    formGen(25, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 26
                case "2john1c26original":
                    displayTextBox.SelectedText = Resources._2john1_26_original;
                    formGen(26, "John 1", 2, "Spent");
                    break;
                case "2john1c26":
                    displayTextBox.SelectedText = "Air Force Dissolution Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    formGen(26, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 27
                case "2john1c27original":
                    displayTextBox.SelectedText = Resources._2john1_27_original;
                    formGen(27, "John 1", 2, "Repealed");
                    break;
                case "2john1c27":
                    displayTextBox.SelectedText = "Fixed Terms Election Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nAmends 2 John 1 c. 2.\r\nRepealed by 6 John 1 c. 30 (Elections Act).\r\nNo vote counts avaliable.";
                    formGen(27, "John 1", 2, "Repealed");
                    break;
                #endregion
                #region Chapter 28
                case "2john1c28original":
                    displayTextBox.SelectedText = Resources._2john1_28_original;
                    formGen(28, "John 1", 2, "In force");
                    break;
                case "2john1c28":
                    displayTextBox.SelectedText = "Dominion (Legislation) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    formGen(28, "John 1", 2, "In force");
                    break;
                #endregion
                #region Chapter 29
                case "2john1c29original":
                    displayTextBox.SelectedText = Resources._2john1_29_original;
                    formGen(29, "John 1", 2, "Spent");
                    break;
                case "2john1c29":
                    displayTextBox.SelectedText = "Her Majesty’s Declaration of Abdication Act (Edstmae)\r\nBy command of the Sovereign.\r\nNo vote counts avaliable.";
                    formGen(29, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 30
                case "2john1c30original":
                    displayTextBox.SelectedText = Resources._2john1_30_original;
                    formGen(30, "John 1", 2, "Spent");
                    break;
                case "2john1c30":
                    displayTextBox.SelectedText = "Military Law Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    formGen(30, "John 1", 2, "Spent");
                    break;
                #endregion
                #endregion
                #region 3 John 1
                case "3john1":
                    longCitation.Text = formats[1];
                    displayTextBox.SelectedText = "3 John 1\r\n\r\n20 June 2019-19 June 2020\r\n\r\nFirst Timpson ministry (Conservative, 14/105)\r\nSecond Timpson ministry (Conservative, 16/105)\r\nMcGrath ministry (Worker's, 2/105)\r\nThird Timpson ministry (Conservative, 13/105)\r\nFirst Sullivan ministry (Conservative, 60/105)\r\n\r\n105 Acts of Parliament";
                    selectionLabel.Text = "3 John 1";
                    break;
                #region Chapter 1
                case "3john1c1original":
                    formGen(1, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_1_original;
                    break;
                case "3john1c1":
                    formGen(1, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Cannabis Act (Legalization)\r\nIntroduced by the Deputy Prime Minister, the Lord Wooler.\r\nRepeals 2 John 1 c. 8.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 2
                case "3john1c2original":
                    formGen(2, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_2_original;
                    break;
                case "3john1c2":
                    formGen(2, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Narcotics Act\r\nIntroduced by the Deputy Prime Minister, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 3
                case "3john1c3original":
                    formGen(3, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_3_original;
                    break;
                case "3john1c3":
                    formGen(3, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Informants Act (Wangatangia)\r\nIntroduced by the Prime Minister of Wangatangia, Lord Mayjames.\r\nRepealed by 3 John 1 c. 72 (Informants (Repeal) Act (Wangatangia))\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 4
                case "3john1c4original":
                    formGen(4, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_4_original;
                    break;
                case "3john1c4":
                    formGen(4, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "National Symbols Act (Baustralian Antarctic Territory)\r\nIntroduced by the Minister for Imperial Affairs, Sir Greg Watts.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 5
                case "3john1c5original":
                    formGen(5, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_5_original;
                    break;
                case "3john1c5":
                    formGen(5, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "National Symbols Act (Edstmae)\r\nIntroduced by the Minister for Imperial Affairs, Sir Greg Watts.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 6
                case "3john1c6original":
                    formGen(6, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_6_original;
                    break;
                case "3john1c6":
                    formGen(6, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "National Symbols Act (Ostreum)\r\nIntroduced by the Minister for Imperial Affairs, Sir Greg Watts.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 7
                case "3john1c7original":
                    formGen(7, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_7_original;
                    break;
                case "3john1c7":
                    formGen(7, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "National Symbols Act (Wangatangia)\r\nIntroduced by the Minister for Imperial Affairs, Sir Greg Watts.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 8
                case "3john1c8original":
                    formGen(8, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_8_original;
                    break;
                case "3john1c8":
                    formGen(8, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Short Titles Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nAmends:\r\n  2 John 1 c. 4.\r\n  2 John 1 c. 11.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 9
                case "3john1c9amend1":
                    formGen(9, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = Resources._3john1_9_amend1;
                    break;
                case "3john1c9original":
                    formGen(9, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = Resources._3john1_9_original;
                    break;
                case "3john1c9":
                    formGen(9, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = "Union with Quebec Act (Baustralia)\r\nIntroduced by the Minister for Spatial Exploration, Aidan McGrath.\r\nRepealed by 3 John 1 c. 18 (Union with Quebec (Repeal) Act (Baustralia)).\r\nAmended by 3 John 1 c. 13 (Union with Quebec (Modifications) Act (Baustralia)).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 10
                case "3john1c10original":
                    formGen(10, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_10_original;
                    break;
                case "3john1c10":
                    formGen(10, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Concealed Firearms Act\r\nIntroduced by the Deputy Prime Minister, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 11
                case "3john1c11original":
                    formGen(11, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_11_original;
                    break;
                case "3john1c11":
                    formGen(11, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Wrythe Convention Act\r\nIntroduced by the Minister for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 12
                case "3john1c12original":
                    formGen(12, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_12_original;
                    break;
                case "3john1c12":
                    formGen(12, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Acts of Parliament (Commencement) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 13
                case "3john1c13original":
                    formGen(13, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = Resources._3john1_13_original;
                    break;
                case "3john1c13":
                    formGen(13, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = "Union with Quebec (Modifications) Act (Baustralia)\r\nIntroduced by the Minister for Foreign Affairs, the Lord Wooler.\r\nAmends 3 John 1 c. 9.\r\nRepealed by 3 John 1 c. 18 (Union with Quebec (Repeal) Act (Baustralia)).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 14
                case "3john1c14original":
                    formGen(14, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_14_original;
                    break;
                case "3john1c14":
                    formGen(14, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Monarchy (Powers) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 15
                case "3john1c15original":
                    formGen(15, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_15_original;
                    break;
                case "3john1c15":
                    formGen(15, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Litihanua Act\r\nIntroduced by the Minister for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 16
                case "3john1c16amend3":
                    formGen(16, "John 1", 3, "Amended");
                    displayTextBox.SelectedText = Resources._3john1_16_amend3;
                    break;
                case "3john1c16amend2":
                    formGen(16, "John 1", 3, "Amended");
                    displayTextBox.SelectedText = Resources._3john1_16_amend2;
                    break;
                case "3john1c16amend1":
                    formGen(16, "John 1", 3, "Amended");
                    displayTextBox.SelectedText = Resources._3john1_16_amend1;
                    break;
                case "3john1c16original":
                    formGen(16, "John 1", 3, "Amended");
                    displayTextBox.SelectedText = Resources._3john1_16_original;
                    break;
                case "3john1c16":
                    formGen(16, "John 1", 3, "Amended");
                    displayTextBox.SelectedText = "Prostitution Act\r\nIntroduced by the Deputy Prime Minister, the Lord Wooler.\r\nAmended by:\r\n  3 John 1 c. 17 (Prostitution (Legalization) Act (Ostreum)).\r\n  3 John 1 c. 73 (Prostitution (Fines) Act).\r\n  3 John 1 c. 79 (Prostitution Act (Ostreum)).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 17
                case "3john1c17original":
                    formGen(17, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = Resources._3john1_17_original;
                    break;
                case "3john1c17":
                    formGen(17, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = "Prostitution (Legalization) Act (Ostreum)\r\nIntroduced by the Viceroy and Lord Governor of Ostreum, the Duke of London.\r\nAmends 3 John 1 c. 16.\r\nRepealed by 3 John 1 c. 79 (Prostitution Act (Ostreum)).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 18
                case "3john1c18original":
                    formGen(18, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_18_original;
                    break;
                case "3john1c18":
                    formGen(18, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Union with Quebec (Repeal) Act (Baustralia)\r\nIntroduced by the Minister for Spatial Exploration, Aidan McGrath.\r\nRepeals:\r\n  3 John 1 c. 9\r\n  3 John 1 c. 13\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 19
                case "3john1c19original":
                    formGen(19, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_19_original;
                    break;
                case "3john1c19":
                    formGen(19, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Taylor Act (Baustralia)\r\nIntroduced by the Minister for Spatial Exploration, Aidan McGrath.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 20
                case "3john1c20original":
                    formGen(20, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_20_original;
                    break;
                case "3john1c20":
                    formGen(20, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Resignation Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 21
                case "3john1c21original":
                    formGen(21, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_21_original;
                    break;
                case "3john1c21":
                    formGen(21, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Grand Unified Micronational (Ratification) Act\r\nIntroduced by the Deputy Prime Minister, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 22
                case "3john1c22original":
                    formGen(22, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_22_original;
                    break;
                case "3john1c22":
                    formGen(22, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Loyal Opposition (Appointment) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 23
                case "3john1c23original":
                    formGen(23, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_23_original;
                    break;
                case "3john1c23":
                    formGen(23, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Loyal Opposition (Roles) Act\r\nIntroduced by the Prime Minister, Sir John Timpson\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 24
                case "3john1c24original":
                    formGen(24, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_24_original;
                    break;
                case "3john1c24":
                    formGen(24, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Whiskey Islands Act\r\nIntroduced by the Minister for Imperial Affairs, Sir Greg Watts.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 25
                case "3john1c25original":
                    formGen(25, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_25_original;
                    break;
                case "3john1c25":
                    formGen(25, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "National Symbols Act (Whiskey Islands)\r\nIntroduced by the Minister for Imperial Affairs, Sir Greg Watts.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 26
                case "3john1c26original":
                    formGen(26, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_26_original;
                    break;
                case "3john1c26":
                    formGen(26, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Secretary of State Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 27
                case "3john1c27amend1":
                    formGen(27, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_27_amend1;
                    break;
                case "3john1c27original":
                    formGen(27, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_27_original;
                    break;
                case "3john1c27":
                    formGen(27, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Mayhew (Claim) Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 28
                case "3john1c28original":
                    formGen(28, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_28_original;
                    break;
                case "3john1c28":
                    formGen(28, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Dominions (Government) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 29
                case "3john1c29original":
                    formGen(29, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_29_original;
                    break;
                case "3john1c29":
                    formGen(29, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Mayhew (Annulment) Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 30
                case "3john1c30original":
                    formGen(30, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_30_original;
                    break;
                case "3john1c30":
                    formGen(30, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Calendar Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 31
                case "3john1c31original":
                    formGen(31, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_31_original;
                    break;
                case "3john1c31":
                    formGen(31, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Baustralian News Network Act\r\nIntroduced by the Prime Minister, Aidan McGrath.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 32
                case "3john1c32original":
                    formGen(32, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_32_original;
                    break;
                case "3john1c32":
                    formGen(32, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "One-Man Party Act\r\nIntroduced by the Prime Minister, Aidan McGrath.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 33
                case "3john1c33original":
                    formGen(33, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_33_original;
                    break;
                case "3john1c33":
                    formGen(33, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Interpretation Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 34
                case "3john1c34amend1":
                    formGen(34, "John 1", 3, "Amended");
                    displayTextBox.SelectedText = Resources._3john1_34_amend1;
                    break;
                case "3john1c34original":
                    formGen(34, "John 1", 3, "Amended");
                    displayTextBox.SelectedText = Resources._3john1_34_original;
                    break;
                case "3john1c34":
                    formGen(34, "John 1", 3, "Amended");
                    displayTextBox.SelectedText = "Colony (No. 1) Act\r\nAmended by 3 John 1 c. 62 (Colony (No. 2) Act)\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 35
                case "3john1c35original":
                    formGen(35, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_35_original;
                    break;
                case "3john1c35":
                    formGen(35, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Handover of the League of Nations Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 36
                case "3john1c36original":
                    formGen(36, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_36_original;
                    break;
                case "3john1c36":
                    formGen(36, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Communications (Office Wordmarks) Act\r\nIntroduced by the Secretary of State for Spatial Exploration, Aidan McGrath.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 37
                case "3john1c37original":
                    formGen(37, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_37_original;
                    break;
                case "3john1c37":
                    formGen(37, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Royal Styles Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 38
                case "3john1c38original":
                    formGen(38, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_38_original;
                    break;
                case "3john1c38":
                    formGen(38, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Fox Islands Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 39
                case "3john1c39original":
                    formGen(39, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_39_original;
                    break;
                case "3john1c39":
                    formGen(39, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "National Symbols Act (Fox Islands)\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 40
                case "3john1c40original":
                    formGen(40, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_40_original;
                    break;
                case "3john1c40":
                    formGen(40, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Oaths Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nAmends 2 John 1 c. 2.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 41
                case "3john1c41amend1":
                    formGen(41, "John 1", 3, "Amended");
                    displayTextBox.SelectedText = Resources._3john1_41_amend1;
                    break;
                case "3john1c41original":
                    formGen(41, "John 1", 3, "Amended");
                    displayTextBox.SelectedText = Resources._3john1_41_original;
                    break;
                case "3john1c41":
                    formGen(41, "John 1", 3, "Amended");
                    displayTextBox.SelectedText = "Citation (Legal) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nAmended by 5 John 1 c. 20 (House of Lords (Identifier) Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 42
                case "3john1c42original":
                    formGen(42, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_42_original;
                    break;
                case "3john1c42":
                    formGen(42, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Human Rights Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 43
                case "3john1c43original":
                    formGen(43, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_43_original;
                    break;
                case "3john1c43":
                    formGen(43, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Boerc Measures Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nRepeals 2 John 1 c. 21.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 44
                case "3john1c44original":
                    formGen(44, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_44_original;
                    break;
                case "3john1c44":
                    formGen(44, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Short Titles (No. 2) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nAmends 2 John 1 c. 15.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 45
                case "3john1c45original":
                    formGen(45, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_45_original;
                    break;
                case "3john1c45":
                    formGen(45, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Treaty of Belcity Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 46
                case "3john1c46original":
                    formGen(46, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_46_original;
                    break;
                case "3john1c46":
                    formGen(46, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Public Health Emergency Measures (Quarantine) Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 47
                case "3john1c47original":
                    formGen(47, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_47_original;
                    break;
                case "3john1c47":
                    formGen(47, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Environment Protection (Littering) Act\r\nIntroduced by the Secretary of State for the Environment, Mecca Thompson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 48
                case "3john1c48amend1":
                    formGen(48, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = Resources._3john1_48_amend1;
                    break;
                case "3john1c48original":
                    formGen(48, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = Resources._3john1_48_original;
                    break;
                case "3john1c48":
                    formGen(48, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = "Persona Non Grata (McGrath, No. 1) Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nRepealed by 3 John 1 c. 85 (Persona Grata (McGrath) Act)\r\nAmended by 3 John 1 c. 103 (Persona Non-Grata (McGrath, No. 2) Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 49
                case "3john1c49original":
                    formGen(49, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_49_original;
                    break;
                case "3john1c49":
                    formGen(49, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Payment Act\r\nIntroduced by the Secretary of State for the Economy, Reagan Greenson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 50
                case "3john1c50original":
                    formGen(50, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_50_original;
                    break;
                case "3john1c50":
                    formGen(50, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Parliament (Activity) Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 51
                case "3john1c51original":
                    formGen(51, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_51_original;
                    break;
                case "3john1c51":
                    formGen(51, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Military Service Act\r\nIntroduced by the Secretary of State for Justice, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 52
                case "3john1c52original":
                    formGen(52, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_52_original;
                    break;
                case "3john1c52":
                    formGen(52, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Routes (Designation) Act\r\nIntroduced by the Secretary of State for Routes, Chase Lameroux.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 53
                case "3john1c53original":
                    formGen(53, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = Resources._3john1_53_original;
                    break;
                case "3john1c53":
                    formGen(53, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = "Monarchy (Immunity) Act\r\nIntroduced by the Secretary of State for the Economy, Reagan Greenson.\r\nRepealed by 3 John 1 c. 57 (Monarchy (Emergency Measures) Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 54
                case "3john1c54original":
                    formGen(54, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = Resources._3john1_54_original;
                    break;
                case "3john1c54":
                    formGen(54, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = "Paloma (Citizenship) Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nRepealed by 3 John 1 c. 85 (Persona Grata (McGrath) Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 55
                case "3john1c55original":
                    formGen(55, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_55_original;
                    break;
                case "3john1c55":
                    formGen(55, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Animal Act\r\nIntroduced by the Secretary of State for the Environment, Mecca Thompson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 56
                case "3john1c56amend1":
                    formGen(56, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_56_amend1;
                    break;
                case "3john1c56original":
                    formGen(56, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_56_original;
                    break;
                case "3john1c56":
                    formGen(56, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Constituencies (No. 1) Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nAmended by 3 John 1 c. 59 (Constituencies (No. 2) Act)\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 57
                case "3john1c57original":
                    formGen(57, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_57_original;
                    break;
                case "3john1c57":
                    formGen(57, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Monarchy (Emergency Measures) Act\r\nRepeals 3 John 1 c. 53.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 58
                case "3john1c58original":
                    formGen(58, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_58_original;
                    break;
                case "3john1c58":
                    formGen(58, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Treaty of Florina Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 59
                case "3john1c59original":
                    formGen(59, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_59_original;
                    break;
                case "3john1c59":
                    formGen(59, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Constituencies (No. 2) Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 60
                case "3john1c60original":
                    formGen(60, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_60_original;
                    break;
                case "3john1c60":
                    formGen(60, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Treaty of San Souci Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 61
                case "3john1c61original":
                    formGen(61, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_61_original;
                    break;
                case "3john1c61":
                    formGen(61, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Speaker of the House of Commons Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 62
                case "3john1c62original":
                    formGen(62, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_62_original;
                    break;
                case "3john1c62":
                    formGen(62, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Colony (No. 2) Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nAmends 3 John 1 c. 34\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 63
                case "3john1c63original":
                    formGen(63, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_63_original;
                    break;
                case "3john1c63":
                    formGen(63, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Treaty of Nuevo Holdertona Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nRepealed by 3 John 1 c. 57 (Monarchy (Emergency Measures) Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 64
                case "3john1c64original":
                    formGen(64, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_64_original;
                    break;
                case "3john1c64":
                    formGen(64, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Cascadia-Paloma City Direct Communications Link Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 65
                case "3john1c65original":
                    formGen(65, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_65_original;
                    break;
                case "3john1c65":
                    formGen(65, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Diplomacy Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 66
                case "3john1c66original":
                    formGen(66, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = Resources._3john1_66_original;
                    break;
                case "3john1c66":
                    formGen(66, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = "Fithiuania (Citizenship) Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nRepealed by 4 John 1 c. 35 (Paloma Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 67
                case "3john1c67original":
                    formGen(67, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_67_original;
                    break;
                case "3john1c67":
                    formGen(67, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Neutrality Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 68
                case "3john1c68original":
                    formGen(68, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_68_original;
                    break;
                case "3john1c68":
                    formGen(68, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Compensation Act\r\nIntroduced by the Secretary of State for the Economy, the Earl Simpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 69
                case "3john1c69original":
                    formGen(69, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_69_original;
                    break;
                case "3john1c69":
                    formGen(69, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Marriage Act\r\nIntroduced by the Secretary of State for Justice, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 70
                case "3john1c70original":
                    formGen(70, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_70_original;
                    break;
                case "3john1c70":
                    formGen(70, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Consent Act\r\nIntroduced by the Secretary of State for Justice, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 71
                case "3john1c71original":
                    formGen(71, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_71_original;
                    break;
                case "3john1c71":
                    formGen(71, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "League of Nations Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 72
                case "3john1c72original":
                    formGen(72, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_72_original;
                    break;
                case "3john1c72":
                    formGen(72, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Informants (Repeal) Act (Wangatangia)\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nRepeals 3 John 1 c. 3\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 73
                case "3john1c73original":
                    formGen(73, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_63_original;
                    break;
                case "3john1c73":
                    formGen(73, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Prostitution (Fines) Act\r\nIntroduced by the Secretary of State for Justice, the Lord Wooler.\r\nAmends 3 John 1 c. 16.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 74
                case "3john1c74original":
                    formGen(74, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_74_original;
                    break;
                case "3john1c74":
                    formGen(74, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Alias Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 75
                case "3john1c75original":
                    formGen(75, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_75_original;
                    break;
                case "3john1c75":
                    formGen(75, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Kingdom's Secret Service Act\r\nIntroduced by the Secretary of State for Justice, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 76
                case "3john1c76original":
                    formGen(76, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_76_original;
                    break;
                case "3john1c76":
                    formGen(76, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Espionage Act\r\nIntroduced by the Secretary of State for Justice, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 77
                case "3john1c77original":
                    formGen(77, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_77_original;
                    break;
                case "3john1c77":
                    formGen(77, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Repealed Crimes (Punishment) Act\r\nIntroduced by the Secretary of State for Justice, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 78
                case "3john1c78original":
                    formGen(78, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_78_original;
                    break;
                case "3john1c78":
                    formGen(78, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "High Treason Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 79
                case "3john1c79original":
                    formGen(79, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_79_original;
                    break;
                case "3john1c79":
                    formGen(79, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Marriage Act\r\nIntroduced by the Secretary of State for Justice, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 80
                case "3john1c80original":
                    formGen(80, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_80_original;
                    break;
                case "3john1c80":
                    formGen(80, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Government (No. 1) Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 81
                case "3john1c81original":
                    formGen(81, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_81_original;
                    break;
                case "3john1c81":
                    formGen(81, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Military (Provost) Act\r\nIntroduced by the Secretary of State for Justice, Sir Oliver Doig.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 82
                case "3john1c82original":
                    formGen(82, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_82_original;
                    break;
                case "3john1c82":
                    formGen(82, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Secretary of State for the Secret Service Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 83
                case "3john1c83original":
                    formGen(83, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_83_original;
                    break;
                case "3john1c83":
                    formGen(83, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Great Lakes Council Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 84
                case "3john1c84original":
                    formGen(84, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_84_original;
                    break;
                case "3john1c84":
                    formGen(84, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "North Fox Islands Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 85
                case "3john1c85original":
                    formGen(85, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_85_original;
                    break;
                case "3john1c85":
                    formGen(85, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Persona Grata (McGrath) Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nRepeals:\r\n  3 John 1 c. 48\r\n  3 John 1 c. 49\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 86
                case "3john1c86original":
                    formGen(86, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_86_original;
                    break;
                case "3john1c86":
                    formGen(86, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Immigration Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 87
                case "3john1c87original":
                    formGen(87, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_87_original;
                    break;
                case "3john1c87":
                    formGen(87, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Labour Act\r\nIntroduced by the Secretary of State for Justice, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 88
                case "3john1c88original":
                    formGen(88, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_88_original;
                    break;
                case "3john1c88":
                    formGen(88, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Persona Non-Grata Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 89
                case "3john1c89":
                    formGen(89, "John 1", 3, "Destroyed");
                    displayTextBox.SelectedText = "Prostitution (Legalization) Act" + formats[4];
                    break;
                #endregion
                #region Chapter 90
                case "3john1c90original":
                    formGen(90, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_90_original;
                    break;
                case "3john1c90":
                    formGen(90, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Discriminatory Groups Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 91
                case "3john1c91original":
                    formGen(91, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = Resources._3john1_91_original;
                    break;
                case "3john1c91":
                    formGen(91, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = "Persona Non-Grata (Morris) Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nRepealed by 3 John 1 c. 101 (Persona Grata (Morris) Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 92
                case "3john1c92original":
                    formGen(92, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = Resources._3john1_92_original;
                    break;
                case "3john1c92":
                    formGen(92, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = "Kapreburg Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nRepealed by 4 John 1 c. 33 (Kapreburg Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 93
                case "3john1c93original":
                    formGen(93, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_93_original;
                    break;
                case "3john1c93":
                    formGen(93, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "His Royal Naval Volunteer Reserve Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 94
                case "3john1c94original":
                    formGen(94, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_94_original;
                    break;
                case "3john1c94":
                    formGen(94, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Naval Amphibious Arm Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 95
                case "3john1c95original":
                    formGen(95, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_95_original;
                    break;
                case "3john1c95":
                    formGen(95, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Provinces Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 96
                case "3john1c96original":
                    formGen(96, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_96_original;
                    break;
                case "3john1c96":
                    formGen(96, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Blackmail Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 97
                case "3john1c97original":
                    formGen(97, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = Resources._3john1_97_original;
                    break;
                case "3john1c97":
                    formGen(97, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = "Voting (Amendment) Act\r\nIntroduced by the Leader of the Opposition, Sir Charles Burgardt.\r\nRepealed by 6 John 1 c. 30 (Elections Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 98
                case "3john1c98original":
                    formGen(98, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = Resources._3john1_98_original;
                    break;
                case "3john1c98":
                    formGen(98, "John 1", 3, "Repealed");
                    displayTextBox.SelectedText = "Government (No. 2) Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nRepealed by 6 John 1 c. 9 (Secretaries of State (Offices) Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 99
                case "3john1c99original":
                    formGen(99, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_99_original;
                    break;
                case "3john1c99":
                    formGen(99, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Continental Act\r\nIntroduced by the Secretary of State for Foreign Affairs, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 100
                case "3john1c100original":
                    formGen(100, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_100_original;
                    break;
                case "3john1c100":
                    formGen(100, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Election (Determination) Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 101
                case "3john1c101original":
                    formGen(101, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_101_original;
                    break;
                case "3john1c101":
                    formGen(101, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Persona Grata (Morris) Act\r\nBy command of the Sovereign.\r\nRepeals 3 John 1 c. 91.";
                    break;
                #endregion
                #region Chapter 102
                case "3john1c102original":
                    formGen(102, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_102_original;
                    break;
                case "3john1c102":
                    formGen(102, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Constituencies (No. 3) Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 103
                case "3john1c103original":
                    formGen(103, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_103_original;
                    break;
                case "3john1c103":
                    formGen(103, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Persona Non-Grata (McGrath, No. 2) Act\r\nBy command of the Sovereign.\r\nAmends 3 John 1 c. 48.\r\nRepealed by 4 John 1 c. 35 (Paloma Act).";
                    break;
                #endregion
                #region Chapter 104
                case "3john1c104original":
                    formGen(104, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_104_original;
                    break;
                case "3john1c104":
                    formGen(104, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Great Lakes Council (Withdrawal) Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 105
                case "3john1c105original":
                    formGen(105, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_105_original;
                    break;
                case "3john1c105":
                    formGen(105, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Citizenship Act\r\nIntroduced by the Prime Minister, Sir Nick Sullivan.\r\nRepeals 2 John 1 c. 12\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #endregion
                #region 4 John 1
                case "4john1":
                    longCitation.Text = formats[1];
                    displayTextBox.SelectedText = "4 John 1\r\n\r\n20 June 2020-19 June 2021\r\n\r\nSecond Sullivan ministry (Conservative, 54/54)\r\n\r\n54 Acts of Parliament";
                    selectionLabel.Text = "4 John 1";
                    break;
                #region Chapter 1
                case "4john1c1original":
                    formGen(1, "John 1", 4, "Amended");
                    displayTextBox.SelectedText = Resources._4john1_1_original;
                    break;
                case "4john1c1amend1":
                    formGen(1, "John 1", 4, "Amended");
                    displayTextBox.SelectedText = Resources._4john1_1_amend1;
                    break;
                case "4john1c1":
                    formGen(1, "John 1", 4, "Amended");
                    displayTextBox.SelectedText = "Order of Precedence (Persons) Act\r\nAmended by 6 John 1 c. 19 (Amendment to the Baustralian Order of Precedence Act)." + formats[5];
                    break;
                #endregion
                #region Chapter 2
                case "4john1c2original":
                    formGen(2, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_2_original;
                    break;
                case "4john1c2":
                    formGen(2, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Order of Precedence (Honours) Act" + formats[5];
                    break;
                #endregion
                #region Chapter 3
                case "4john1c3original":
                    formGen(3, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_3_original;
                    break;
                case "4john1c3":
                    formGen(3, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Military Service Act" + formats[5];
                    break;
                #endregion
                #region Chapter 4
                case "4john1c4original":
                    formGen(4, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_4_original;
                    break;
                case "4john1c4":
                    formGen(4, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Military Service Act" + formats[5];
                    break;
                #endregion
                #region Chapter 5
                case "4john1c5original":
                    formGen(5, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_5_original;
                    break;
                case "4john1c5":
                    formGen(5, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Salaries Act" + formats[5];
                    break;
                #endregion
                #region Chapter 6
                case "4john1c6original":
                    formGen(6, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_6_original;
                    break;
                case "4john1c6":
                    formGen(6, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Criminalization of Murder Act" + formats[5];
                    break;
                #endregion
                #region Chapter 7
                case "4john1c7original":
                    formGen(7, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_7_original;
                    break;
                case "4john1c7":
                    formGen(7, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Criminalization of Theft Act" + formats[5];
                    break;
                #endregion
                #region Chapter 8
                case "4john1c8original":
                    formGen(8, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_8_original;
                    break;
                case "4john1c8":
                    formGen(8, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Assault and Battery Act" + formats[5];
                    break;
                #endregion
                #region Chapter 9
                case "4john1c9original":
                    formGen(9, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_9_original;
                    break;
                case "4john1c9":
                    formGen(9, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Fraud Act" + formats[5];
                    break;
                #endregion
                #region Chapter 10
                case "4john1c10":
                    formGen(10, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "COVID Act" + formats[4];
                    break;
                #endregion
                #region Chapter 11
                case "4john1c11":
                    formGen(11, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Constituencies Act" + formats[4];
                    break;
                #endregion
                #region Chapter 12
                case "4john1c12":
                    formGen(12, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "House of Lords (Influence) Act" + formats[4];
                    break;
                #endregion
                #region Chapter 13
                case "4john1c13original":
                    formGen(13, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_13_original;
                    break;
                case "4john1c13":
                    formGen(13, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "House of Lords (Powers) Act" + formats[5];
                    break;
                #endregion
                #region Chapter 14
                case "4john1c14":
                    formGen(14, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "House of Lords (Majorities) Act" + formats[4];
                    break;
                #endregion
                #region Chapter 15
                case "4john1c15":
                    formGen(15, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "House of Lords Act" + formats[4];
                    break;
                #endregion
                #region Chapter 16
                case "4john1c16original":
                    formGen(16, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_16_original;
                    break;
                case "4john1c16":
                    formGen(16, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Official Secrets Act" + formats[5];
                    break;
                #endregion
                #region Chapter 17
                case "4john1c17":
                    formGen(17, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Freedom of Information Act" + formats[4];
                    break;
                #endregion
                #region Chapter 18
                case "4john1c18original":
                    formGen(18, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = Resources._4john1_18_original;
                    break;
                case "4john1c18":
                    formGen(18, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = "Citation (Succession Law) Act\r\nAmends 1 John 1 c. 3." + formats[5];
                    break;
                #endregion
                #region Chapter 19
                case "4john1c19original":
                    formGen(19, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = Resources._4john1_19_original;
                    break;
                case "4john1c19":
                    formGen(19, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = "Mission of the Cupertino Alliance (Ratification) Act" + formats[5];
                    break;
                #endregion
                #region Chapter 20
                case "4john1c20":
                    formGen(20, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Constituencies (No. 2) Act" + formats[4];
                    break;
                #endregion
                #region Chapter 21
                case "4john1c21":
                    formGen(21, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Tri-Citizenship Act" + formats[4];
                    break;
                #endregion
                #region Chapter 22
                case "4john1c22":
                    formGen(22, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Identification Act" + formats[4];
                    break;
                #endregion
                #region Chapter 23
                case "4john1c23original":
                    formGen(23, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_23_original;
                    break;
                case "4john1c23":
                    formGen(23, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "National Sales Tax Act" + formats[5];
                    break;
                #endregion
                #region Chapter 24
                case "4john1c24original":
                    formGen(24, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_24_original;
                    break;
                case "4john1c24":
                    formGen(24, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Corporate Tax Act" + formats[5];
                    break;
                #endregion
                #region Chapter 25
                case "4john1c25":
                    formGen(25, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Organized Crime Act" + formats[4];
                    break;
                #endregion
                #region Chapter 26
                case "4john1c26original":
                    formGen(26, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = Resources._4john1_26_original;
                    break;
                case "4john1c26":
                    formGen(26, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = "Treaty of Rajagriha (Ratification) Act" + formats[5];
                    break;
                #endregion
                #region Chapter 27
                case "4john1c27original":
                    formGen(27, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_27_original;
                    break;
                case "4john1c27":
                    formGen(27, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Tax Crimes Act" + formats[5];
                    break;
                #endregion
                #region Chapter 28
                case "4john1c28":
                    formGen(28, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Motion Picture and Television Ratings Act" + formats[4];
                    break;
                #endregion
                #region Chapter 29
                case "4john1c29original":
                    formGen(29, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_29_original;
                    break;
                case "4john1c29":
                    formGen(29, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Currency and Banknotes Act" + formats[5];
                    break;
                #endregion
                #region Chapter 30
                case "4john1c30original":
                    formGen(30, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_30_original;
                    break;
                case "4john1c30":
                    formGen(30, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Stolen Honours and Arms Act" + formats[5];
                    break;
                #endregion
                #region Chapter 31
                case "4john1c31original":
                    formGen(31, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_31_original;
                    break;
                case "4john1c31":
                    formGen(31, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "Weights and Measures Act" + formats[5];
                    break;
                #endregion
                #region Chapter 32
                case "4john1c32":
                    formGen(32, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Peerage (Disclamation) Act" + formats[4];
                    break;
                #endregion
                #region Chapter 33
                case "4john1c33original":
                    formGen(33, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = Resources._4john1_33_original;
                    break;
                case "4john1c33":
                    formGen(33, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = "Kapreburg Act\r\nRepeals 3 John 1 c. 92." + formats[5];
                    break;
                #endregion
                #region Chapter 34
                case "4john1c34":
                    formGen(34, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Orders-in-Council Act" + formats[4];
                    break;
                #endregion
                #region Chapter 35
                case "4john1c35original":
                    formGen(35, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = Resources._4john1_35_original;
                    break;
                case "4john1c35":
                    formGen(35, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = "Paloma Act\r\nRepeals\r\n  3 John 1 c. 66\r\n  3 John 1 c. 103" + formats[5];
                    break;
                #endregion
                #region Chapter 36
                case "4john1c36":
                    formGen(36, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Princeton Act" + formats[4];
                    break;
                #endregion
                #region Chapter 37
                case "4john1c37":
                    formGen(37, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Princetin Act" + formats[4];
                    break;
                #endregion
                #region Chapter 38
                case "4john1c38":
                    formGen(38, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "National Symbols (Princetin) Act" + formats[4];
                    break;
                #endregion
                #region Chapter 39
                case "4john1c39":
                    formGen(39, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Holderton (Symbols) Act" + formats[4];
                    break;
                #endregion
                #region Chapter 40
                case "4john1c40":
                    formGen(40, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Holderton Herald Act" + formats[4];
                    break;
                #endregion
                #region Chapter 41
                case "4john1c41original":
                    formGen(41, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = Resources._4john1_41_original;
                    break;
                case "4john1c41":
                    formGen(41, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = "Ostreum (Reorganization) Act" + formats[5];
                    break;
                #endregion
                #region Chapter 42
                case "4john1c42original":
                    formGen(42, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = Resources._4john1_42_original;
                    break;
                case "4john1c42":
                    formGen(42, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = "Royal Styles Act" + formats[5];
                    break;
                #endregion
                #region Chapter 43
                case "4john1c43original":
                    formGen(43, "John 1", 4, "In force");
                    displayTextBox.SelectedText = Resources._4john1_43_original;
                    break;
                case "4john1c43":
                    formGen(43, "John 1", 4, "In force");
                    displayTextBox.SelectedText = "National Symbols (Ostreum) Act" + formats[5];
                    break;
                #endregion
                #region Chapter 44
                case "4john1c44":
                    formGen(44, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Princetin (Referendum) Act" + formats[4];
                    break;
                #endregion
                #region Chapter 45
                case "4john1c45original":
                    formGen(45, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = Resources._4john1_45_original;
                    break;
                case "4john1c45":
                    formGen(45, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = "Paloma City Agreement (Modifications) Act" + formats[5];
                    break;
                #endregion
                #region Chapter 46
                case "4john1c46":
                    formGen(46, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Baustralian Antarctic Territory Act" + formats[4];
                    break;
                #endregion
                #region Chapter 47
                case "4john1c47":
                    formGen(47, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "New Princetin Act";
                    break;
                #endregion
                #region Chapter 48
                case "4john1c48":
                    formGen(48, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "National Symbols (New Princetin) Act" + formats[4];
                    break;
                #endregion
                #region Chapter 49
                case "4john1c49":
                    formGen(49, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Paloma City Agreement (Modification) Act" + formats[4];
                    break;
                #endregion
                #region Chapter 50
                case "4john1c50original":
                    formGen(50, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = Resources._4john1_50_original;
                    break;
                case "4john1c50":
                    formGen(50, "John 1", 4, "Spent");
                    displayTextBox.SelectedText = "Oaths Act.\r\nAmends 2 John 1 c. 2" + formats[5];
                    break;
                #endregion
                #region Chapter 51
                case "4john1c51":
                    formGen(51, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Blackmail Act" + formats[4];
                    break;
                #endregion
                #region Chapter 52
                case "4john1c52original":
                    formGen(52, "John 1", 4, "Repealed");
                    displayTextBox.SelectedText = Resources._4john1_52_original;
                    break;
                case "4john1c52":
                    formGen(52, "John 1", 4, "Repealed");
                    displayTextBox.SelectedText = "Imperial Boundries Act\r\nRepealed by 5 John 1 c. 13 (Imperial Boundaries Act)." + formats[5];
                    break;
                #endregion
                #region Chapter 53
                case "4john1c53":
                    formGen(53, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Constituencies (No. 3) Act" + formats[4];
                    break;
                #endregion
                #region Chapter 54
                case "4john1c54":
                    formGen(54, "John 1", 4, "Destroyed");
                    displayTextBox.SelectedText = "Imperial Constituencies Act" + formats[4];
                    break;
                #endregion
                #endregion
                #region 5 John 1
                case "5john1":
                    longCitation.Text = formats[1];
                    displayTextBox.SelectedText = "5 John 1\r\n\r\n20 June 2021-19 June 2022\r\n\r\nParker ministry (Conservative, 37/37)\r\n\r\n37 Acts of Parliament";
                    selectionLabel.Text = "5 John 1";
                    break;
                #region Chapter 1
                case "5john1c1amend1":
                    formGen(1, "John 1", 5, "Amended");
                    displayTextBox.SelectedText = Resources._5john1_1_amend1;
                    break;
                case "5john1c1original":
                    formGen(1, "John 1", 5, "Amended");
                    displayTextBox.SelectedText = Resources._5john1_1_original;
                    break;
                case "5john1c1":
                    formGen(1, "John 1", 5, "Amended");
                    displayTextBox.SelectedText = "Titles and Styles Act\r\nIntroduced by the Prime Minister, Lady Ella Parker.\r\nAmended by 5 John 1 c. 9 (Titles and Styles (No. 2) Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 2
                case "5john1c2amend1":
                    formGen(2, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_2_amend1;
                    break;
                case "5john1c2original":
                    formGen(2, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_2_original;
                    break;
                case "5john1c2":
                    formGen(2, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "National Routes Act" + formats[5];
                    break;
                #endregion
                #region Chapter 3
                case "5john1c3":
                    formGen(3, "John 1", 5, "Destroyed");
                    displayTextBox.SelectedText = "Land Administration Act" + formats[4];
                    break;
                #endregion
                #region Chapter 4
                case "5john1c4original":
                    formGen(4, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_4_original;
                    break;
                case "5john1c4":
                    formGen(4, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Routes (Ostreum) Act" + formats[5];
                    break;
                #endregion
                #region Chapter 5
                case "5john1c5original":
                    formGen(5, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_5_original;
                    break;
                case "5john1c5":
                    formGen(5, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Newport Act" + formats[5];
                    break;
                #endregion
                #region Chapter 6
                case "5john1c6original":
                    formGen(6, "John 1", 5, "In force");
                    displayTextBox.SelectedText = Resources._5john1_6_original;
                    break;
                case "5john1c6":
                    formGen(6, "John 1", 5, "In force");
                    displayTextBox.SelectedText = "Companies Act" + formats[5];
                    break;
                #endregion
                #region Chapter 7
                case "5john1c7amend1":
                    formGen(7, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_7_amend1;
                    break;
                case "5john1c7original":
                    formGen(7, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_7_original;
                    break;
                case "5john1c7":
                    formGen(7, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Restoration of Legislation Act\r\nIntroduced by the Prime Minister, Lady Ella Parker.\r\nNo vote counts avaliable.\r\nAmended by 6 John 1 c. 40 (Restoration of Legislation Act).";
                    break;
                #endregion
                #region Chapter 8
                case "5john1c8original":
                    formGen(8, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_8_original;
                    break;
                case "5john1c8":
                    formGen(8, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "His Royal Air Force Act\r\nIntroduced by the Secretary of State for Defence, Sir John Timpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 9
                case "5john1c9original":
                    formGen(9, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_9_original;
                    break;
                case "5john1c9":
                    formGen(9, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Titles and Styles (No. 2) Act\r\nIntroduced by the Prime Minister, Lady Ella Parker.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 10
                case "5john1c10original":
                    formGen(10, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_10_original;
                    break;
                case "5john1c10":
                    formGen(10, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Île aux Couleuvres Act\r\nIntroduced by the Deputy Prime Minister, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 11
                case "5john1c11original":
                    formGen(11, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_11_original;
                    break;
                case "5john1c11":
                    formGen(11, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "South Wabasso-Westminster Act\r\nIntroduced by the Secretary of State for the Economy, Sir Nick Sullivan.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 12
                case "5john1c12original":
                    formGen(12, "John 1", 5, "In force");
                    displayTextBox.SelectedText = Resources._5john1_12_original;
                    break;
                case "5john1c12":
                    formGen(12, "John 1", 5, "In force");
                    displayTextBox.SelectedText = "Foreign Honours Act\r\nIntroduced by the Secretary of State for Foreign Affairs and the Colonies, the Lord Wooler.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 13
                case "5john1c13original":
                    formGen(13, "John 1", 5, "In force");
                    displayTextBox.SelectedText = Resources._5john1_13_original;
                    break;
                case "5john1c13":
                    formGen(13, "John 1", 5, "In force");
                    displayTextBox.SelectedText = "Imperial Boundaries Act\r\nIntroduced by the Prime Minister, Lady Ella Parker.\r\nRepeals 4 John 1 c. 52.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 14
                case "5john1c14original":
                    formGen(14, "John 1", 5, "In force");
                    displayTextBox.SelectedText = Resources._5john1_14_original;
                    break;
                case "5john1c14":
                    formGen(14, "John 1", 5, "In force");
                    displayTextBox.SelectedText = "Constituencies Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 15
                case "5john1c15original":
                    formGen(15, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_15_original;
                    break;
                case "5john1c15":
                    formGen(15, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Nova Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 16
                case "5john1c16original":
                    formGen(16, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_16_original;
                    break;
                case "5john1c16":
                    formGen(16, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Gloucester Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 17
                case "5john1c17original":
                    formGen(17, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_17_original;
                    break;
                case "5john1c17":
                    formGen(17, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Dynexistan Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 18
                case "5john1c18original":
                    formGen(18, "John 1", 5, "In force");
                    displayTextBox.SelectedText = Resources._5john1_18_original;
                    break;
                case "5john1c18":
                    formGen(18, "John 1", 5, "In force");
                    displayTextBox.SelectedText = "Citation (Bills) Act\r\nBill citations: T50\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 19
                case "5john1c19original":
                    formGen(19, "John 1", 5, "Amended");
                    displayTextBox.SelectedText = Resources._5john1_19_original;
                    break;
                case "5john1c19amend1":
                    formGen(19, "John 1", 5, "Amended");
                    displayTextBox.SelectedText = Resources._5john1_19_amend1;
                    break;
                case "5john1c19":
                    formGen(19, "John 1", 5, "Amended");
                    displayTextBox.SelectedText = "Political Activities Act\r\nBill citations: C50\r\nIntroduced by the Prime Minister, Lady Ella Parker\r\nAmended by 5 John 1 c. 29 (Political Activities (Amendment) Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 20
                case "5john1c20original":
                    formGen(20, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_20_original;
                    break;
                case "5john1c20":
                    formGen(20, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "House of Lords (Identifier) Act\r\nBill citations: T51\r\nBy command of the Sovereign.\r\nAmends 3 John 1 c. 41.";
                    break;
                #endregion
                #region Chapter 21
                case "5john1c21original":
                    formGen(21, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_21_original;
                    break;
                case "5john1c21":
                    formGen(21, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Holderton County Act\r\nBill citations: T52\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 22
                case "5john1c22original":
                    formGen(22, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_22_original;
                    break;
                case "5john1c22":
                    formGen(22, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Public Health Emergency Measures (Confirmation) Act\r\nBill citations: C51\r\nIntroduced by the Prime Minister, Lady Ella Parker.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 23
                case "5john1c23original":
                    formGen(23, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_23_original;
                    break;
                case "5john1c23":
                    formGen(23, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Popular Route Sign Act\r\nBill citations: C52\r\nIntroduced by the Prime Minister, Lady Ella Parker.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 24
                case "5john1c24original":
                    formGen(24, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_24_original;
                    break;
                case "5john1c24":
                    formGen(24, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Routes Act (Ostreum)\r\nBill citations: L51\r\nIntroduced by the Lord Governor of Ostreum, the Duke of London.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 25
                case "5john1c25original":
                    formGen(25, "John 1", 5, "In force");
                    displayTextBox.SelectedText = Resources._5john1_25_original;
                    break;
                case "5john1c25":
                    formGen(25, "John 1", 5, "In force");
                    displayTextBox.SelectedText = "National Symbols Act (Wangatangia)\r\nBill citations: L52\r\nIntroduced by the Lord Governor of Wangatangia, the Lord Mayjames.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 26
                case "5john1c26original":
                    formGen(26, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_26_original;
                    break;
                case "5john1c26":
                    formGen(26, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Mild Pond Act\r\nBill citations: T53\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 27
                case "5john1c27original":
                    formGen(27, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_27_original;
                    break;
                case "5john1c27":
                    formGen(27, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Monaghan Act\r\nBill citations: T54\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 28
                case "5john1c28original":
                    formGen(28, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_28_original;
                    break;
                case "5john1c28":
                    formGen(28, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Fox Islands Act\r\nBill citations: T55\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 29
                case "5john1c29original":
                    formGen(29, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_29_original;
                    break;
                case "5john1c29":
                    formGen(29, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Political Activities (Amendment) Act\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 30
                case "5john1c30original":
                    formGen(30, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_30_original;
                    break;
                case "5john1c30":
                    formGen(30, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Monaghan (No. 2) Act\r\nBill citations: T56\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 31
                case "5john1c31original":
                    formGen(31, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_31_original;
                    break;
                case "5john1c31":
                    formGen(31, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Newport (Routes and Territory) Act\r\nBill citations: T57\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 32
                case "5john1c32original":
                    formGen(32, "John 1", 5, "Repealed");
                    displayTextBox.SelectedText = Resources._5john1_32_original;
                    break;
                case "5john1c32amend1":
                    formGen(32, "John 1", 5, "Repealed");
                    displayTextBox.SelectedText = Resources._5john1_32_amend1;
                    break;
                case "5john1c32":
                    formGen(32, "John 1", 5, "Repealed");
                    displayTextBox.SelectedText = "Colonial Routes Act\r\nBill citations: T58\r\nAmended by 3 John 1 c. 34 (Routes Act).\r\nRepealed by 5 John 1 c. 36 (Colonial Routes (No. 2) Act).\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 33
                case "5john1c33original":
                    formGen(33, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_33_original;
                    break;
                case "5john1c33":
                    formGen(33, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Holderton Act\r\nBill citations: T59\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 34
                case "5john1c34original":
                    formGen(34, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_34_original;
                    break;
                case "5john1c34":
                    formGen(34, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Routes Act\r\nBill citations: T510\r\nAmends 5 John 1 c. 32.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 35
                case "5john1c35original":
                    formGen(35, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_35_original;
                    break;
                case "5john1c35":
                    formGen(35, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Constituencies (No. 2) Act\r\nBill citations: T511\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 36
                case "5john1c36original":
                    formGen(36, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_36_original;
                    break;
                case "5john1c36":
                    formGen(36, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Colonial Routes (No. 2) Act\r\nBill citations: T512\r\nRepeals 5 John 1 c. 32.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 37
                case "5john1c37original":
                    formGen(37, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = Resources._5john1_37_original;
                    break;
                case "5john1c37":
                    formGen(37, "John 1", 5, "Spent");
                    displayTextBox.SelectedText = "Vienna Act\r\nBill citations: T513\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #endregion
                #region 6 John 1
                case "6john1":
                    longCitation.Text = formats[1];
                    displayTextBox.SelectedText = "6 John 1\r\n\r\n20 June 2022-19 June 2023\r\n\r\nBurgardt-Morris ministry (Coalition), 9/36)\r\nBurgardt ministry (Liberal), 10/36)\r\nDoig ministry (Conservative), 17/36)\r\n\r\n36 Acts of Parliament";
                    selectionLabel.Text = "6 John 1";
                    break;
                #region Chapter 1
                case "6john1c1original":
                    formGen(1, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_1_original;
                    break;
                case "6john1c1":
                    formGen(1, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Parliament Extension (No. 1) Act\r\nBill citations: T611\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 2
                case "6john1c2original":
                    formGen(2, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_2_original;
                    break;
                case "6john1c2":
                    formGen(2, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Parliament Extension (No. 2) Act\r\nBill citations: T621\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 3
                case "6john1c3amend1":
                    formGen(3, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_3_amend1;
                    break;
                case "6john1c3original":
                    formGen(3, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_3_original;
                    break;
                case "6john1c3":
                    formGen(3, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Secretaries of State (No. 1) Act\r\nBill citations: C611.\r\nIntroduced by the Prime Minister, Sir Charles Burgardt\r\nAmended by 6 John 1 c. 17 (Secretaries of State (No. 2) Act).\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 4
                case "6john1c4original":
                    formGen(4, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_4_original;
                    break;
                case "6john1c4":
                    formGen(4, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Crown (Heraldry) Act\r\nBill citations: T631\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 5
                case "6john1c5original":
                    formGen(5, "John 1", 6, "Spent", new figures_6john1c5());
                    displayTextBox.SelectedText = Resources._6john1_5_original;
                    break;
                case "6john1c5":
                    formGen(5, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "National Symbols (Referendum) Act\r\nBill citations: C621.\r\nIntroduced by the Member of Parliament for Marlborough, Aidan McGrath\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 6
                case "6john1c6original":
                    formGen(6, "John 1", 6, "In force");
                    displayTextBox.SelectedText = Resources._6john1_6_original;
                    break;
                case "6john1c6":
                    formGen(6, "John 1", 6, "In force");
                    displayTextBox.SelectedText = "National Symbols Act\r\nBill citations: C631.\r\nIntroduced by the Member of Parliament for Marlborough, Aidan McGrath\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 7
                case "6john1c7original":
                    formGen(7, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_7_original;
                    break;
                case "6john1c7":
                    formGen(7, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Royal Titles Act\r\nBill citations: T641.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 8
                case "6john1c8original":
                    formGen(8, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_8_original;
                    break;
                case "6john1c8":
                    formGen(8, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Dynexistan Act\r\nBill citations: T651.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 9
                case "6john1c9original":
                    formGen(9, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_9_original;
                    break;
                case "6john1c9":
                    formGen(9, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Secretaries of State (Offices) Act\r\nBill citations: L611.\r\nIntroduced by the Duke of Northumbria.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 10
                case "6john1c10original":
                    formGen(10, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_10_original;
                    break;
                case "6john1c10":
                    formGen(10, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Reserve Forces Act\r\nBill citations: T661.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 11
                case "6john1c11original":
                    formGen(11, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_11_original;
                    break;
                case "6john1c11":
                    formGen(11, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Routes (Establishing Proposals) Act\r\nBill citations: T671.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 12
                case "6john1c12original":
                    formGen(12, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_12_original;
                    break;
                case "6john1c12":
                    formGen(12, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Bowmanton Act\r\nBill citations: T681.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 13
                case "6john1c13amend1":
                    formGen(13, "John 1", 6, "Amended");
                    displayTextBox.SelectedText = Resources._6john1_13_amend1;
                    break;
                case "6john1c13original":
                    formGen(13, "John 1", 6, "Amended");
                    displayTextBox.SelectedText = Resources._6john1_13_original;
                    break;
                case "6john1c13":
                    formGen(13, "John 1", 6, "Amended");
                    displayTextBox.SelectedText = "Strike Act\r\nBill citations: C641.\r\nIntroduced by the Secretary of State for the Economy, Ava Calero.\r\nAmended by 6 John 1 c. 14 (Strike Act (Amendments) Act).\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 14
                case "6john1c14original":
                    formGen(14, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_14_original;
                    break;
                case "6john1c14":
                    formGen(14, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Strike Act (Amendments) Act\r\nBill citations: C651.\r\nIntroduced by the Member of Parliament for Gloucester, Arthur Lacey-Scott.\r\nAmends 6 John 1 c. 15.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 15
                case "6john1c15original":
                    formGen(15, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_15_original;
                    break;
                case "6john1c15":
                    formGen(15, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Stonia Act\r\nBill citations: T681.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 16
                case "6john1c16original":
                    formGen(16, "John 1", 6, "In force");
                    displayTextBox.SelectedText = Resources._6john1_16_original;
                    break;
                case "6john1c16":
                    formGen(16, "John 1", 6, "In force");
                    displayTextBox.SelectedText = "By-Elections Act\r\nBill citations: C671.\r\nIntroduced by the Leader of the Opposition, Sir Oliver Doig.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 17
                case "6john1c17original":
                    formGen(17, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_17_original;
                    break;
                case "6john1c17":
                    formGen(17, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Secretaries of State (No. 2) Act\r\nBill citations: C661.\r\nIntroduced by the Secretary of State for the Economy, Ava Calero.\r\nAmends 6 John 1 c. 3.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 18
                case "6john1c18original":
                    formGen(18, "John 1", 6, "In force");
                    displayTextBox.SelectedText = Resources._6john1_18_original;
                    break;
                case "6john1c18amend1":
                    formGen(18, "John 1", 6, "In force");
                    displayTextBox.SelectedText = Resources._6john1_18_amend1;
                    break;
                case "6john1c18":
                    formGen(18, "John 1", 6, "In force");
                    displayTextBox.SelectedText = "Succession Law (Modifications, No. 1) Act\r\nBill citations: C691.\r\nIntroduced by the Prime Minister, Sir Charles Burgardt.\r\nRepeals 2 John 1 c. 11.\r\nAmended by 6 John 1 c. 32 (Succession Law (Modifications, No. 2) Act).\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 19
                case "6john1c19original":
                    formGen(19, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_19_original;
                    break;
                case "6john1c19":
                    formGen(19, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Amendment to the Baustralian Order of Precedence Act\r\nBill citations: T691.\r\nAmends 4 John 1 c. 1\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 20
                case "6john1c20original":
                    formGen(20, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_20_original;
                    break;
                case "6john1c20":
                    formGen(20, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Highways (Stonia) Act\r\nBill citations: C6111.\r\nIntroduced by the Secretary of State for Routes, Lady Ella Parker.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 21
                case "6john1c21original":
                    formGen(21, "John 1", 6, "In force");
                    displayTextBox.SelectedText = Resources._6john1_21_original;
                    break;
                case "6john1c21":
                    formGen(21, "John 1", 6, "In force");
                    displayTextBox.SelectedText = "Firearms (Restrictions) Act\r\nBill citations: C6121.\r\nIntroduced by the Secretary of State for Justice, William Perks.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 22
                case "6john1c22original":
                    formGen(22, "John 1", 6, "In force");
                    displayTextBox.SelectedText = Resources._6john1_22_original;
                    break;
                case "6john1c22":
                    formGen(22, "John 1", 6, "In force");
                    displayTextBox.SelectedText = "Firearms (Military) Act\r\nBill citations: C6131.\r\nIntroduced by the Prime Minister, Sir Oliver Doig.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 23
                case "6john1c23original":
                    formGen(23, "John 1", 6, "In force");
                    displayTextBox.SelectedText = Resources._6john1_23_original;
                    break;
                case "6john1c23":
                    formGen(23, "John 1", 6, "In force");
                    displayTextBox.SelectedText = "Popular Route Sign Act\r\nBill citations: T6101.\r\nBy command of the Sovereign, and Consent of the Commons.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 24
                case "6john1c24original":
                    formGen(24, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_24_original;
                    break;
                case "6john1c24":
                    formGen(24, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Secretaries of State (No. 3) Act\r\nBill citations: C6141.\r\nIntroduced by the Secretary of State for Equality and Economic Inclusion, Sir James Gardner.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 25
                case "6john1c25original":
                    formGen(25, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_25_original;
                    break;
                case "6john1c25":
                    formGen(25, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Maintenance Office Act\r\nBill citations: C6151.\r\nIntroduced by the Prime Minister, Sir Oliver Doig.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 26
                case "6john1c26original":
                    formGen(26, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_26_original;
                    break;
                case "6john1c26":
                    formGen(26, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Colonial Routes Act\r\nBill citations: C6161.\r\nIntroduced by the Secretary of State for Routes, Lady Ella Parker.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 27
                case "6john1c27original":
                    formGen(27, "John 1", 6, "In force");
                    displayTextBox.SelectedText = Resources._6john1_27_original;
                    break;
                case "6john1c27":
                    formGen(27, "John 1", 6, "In force");
                    displayTextBox.SelectedText = "Pittsburgh Act\r\nBill citations: T6111.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 28
                case "6john1c28original":
                    formGen(28, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_28_original;
                    break;
                case "6john1c28":
                    formGen(28, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Routes (Redesignations) Act\r\nBill citations: T6121.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 29
                case "6john1c29original":
                    formGen(29, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_29_original;
                    break;
                case "6john1c29":
                    formGen(29, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Peerage Act\r\nBill citations: T6131.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 30
                case "6john1c30original":
                    formGen(30, "John 1", 6, "In force");
                    displayTextBox.SelectedText = Resources._6john1_30_original;
                    break;
                case "6john1c30":
                    formGen(30, "John 1", 6, "In force");
                    displayTextBox.SelectedText = "Elections Act\r\nBill citations: C6171.\r\nIntroduced by the Prime Minister, Sir Oliver Doig.\r\nRepeals:\r\n  2 John 1 c. 27\r\n  3 John 1 c. 97\r\nAmended by 6 John 1 c. 31.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 31
                case "6john1c31original":
                    formGen(31, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_31_original;
                    break;
                case "6john1c31":
                    formGen(31, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Elections (Amendment) Act\r\nBill citations: T6131.\r\nAmends 6 John 1 c. 30.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 32
                case "6john1c32original":
                    formGen(32, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_32_original;
                    break;
                case "6john1c32":
                    formGen(32, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Succession Law (Modifications, No. 2) Act\r\nBill citations: C6181.\r\nIntroduced by the Prime Minister, Sir Oliver Doig.\r\nAmends 6 John 1 c. 18.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 33
                case "6john1c33original":
                    formGen(33, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_33_original;
                    break;
                case "6john1c33":
                    formGen(33, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Secretaries of State (No. 4) Act\r\nBill citations: C6191.\r\nIntroduced by the Secretary of State for Equality, Thomas Jacobs.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 34
                case "6john1c34original":
                    formGen(34, "John 1", 6, "In force");
                    displayTextBox.SelectedText = Resources._6john1_34_original;
                    break;
                case "6john1c34":
                    formGen(34, "John 1", 6, "In force");
                    displayTextBox.SelectedText = "Routes Act\r\nBill citations: T6141.\r\nBy command of the Sovereign, and Consent of the Commons.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 35
                case "6john1c35original":
                    formGen(35, "John 1", 6, "In force");
                    displayTextBox.SelectedText = Resources._6john1_35_original;
                    break;
                case "6john1c35":
                    formGen(35, "John 1", 6, "In force");
                    displayTextBox.SelectedText = "Constituencies (No. 2) Act\r\nBill citations: T6151.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 36
                case "6john1c36original":
                    formGen(36, "John 1", 6, "In force");
                    displayTextBox.SelectedText = Resources._6john1_36_original;
                    break;
                case "6john1c36":
                    formGen(36, "John 1", 6, "In force");
                    displayTextBox.SelectedText = "Colonial Routes (No. 2) Act\r\nBill citations: T6161\r\nBy command of the Sovereign, and Consent of the Commons.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 37
                case "6john1c37original":
                    formGen(37, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_37_original;
                    break;
                case "6john1c37":
                    formGen(37, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Website Act\r\nBill citations: T6171.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 38
                case "6john1c38original":
                    formGen(38, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_38_original;
                    break;
                case "6john1c38":
                    formGen(38, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Acts of Parliament (Electronic Publishing) Act\r\nBill citations: T6181.\r\nBy command of the Sovereign.";
                    break;
                #endregion
                #region Chapter 39
                case "6john1c39original":
                    formGen(39, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_39_original;
                    break;
                case "6john1c39":
                    formGen(39, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Lords Appellant Act\r\nBill citations: C6201.\r\nIntroduced by the Prime Minister, Sir Oliver Doig.\r\n" + votes.details(selector.ToLower());
                    break;
                #endregion
                #region Chapter 40
                case "6john1c40original":
                    formGen(40, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = Resources._6john1_40_original;
                    break;
                case "6john1c40":
                    formGen(40, "John 1", 6, "Spent");
                    displayTextBox.SelectedText = "Restoration of Legislation Act\r\nBill citations: T6191.\r\nBy command of the Sovereign.\r\nAmends 5 John 1 c. 7.";
                    break;
                #endregion
                #endregion
                #region Bills
                case "bills":
                    longCitation.Text = "Bills of Parliament";
                    displayTextBox.SelectedText = "This section displays bills in progress, or which have failed.";
                    selectionLabel.Text = "Bills";
                    break;
                #region Monarchy Bill
                case "monarchybill1":
                    longCitation.Text = string.Format("A Bill deposing the Caravaggio's from the Baustralian Imperial Throne and replacing them with the Timpson family");
                    selectionLabel.Text = string.Format("Bill C14. Status: Failed.");
                    displayTextBox.SelectedText = Resources.monarchybill1;
                    break;
                case "monarchybill2":
                    longCitation.Text = string.Format("A Bill deposing the Caravaggio's from the Baustralian Imperial Throne and replacing them with the Timpson family");
                    selectionLabel.Text = string.Format("Bill C15. Status: Failed.");
                    displayTextBox.SelectedText = Resources.monarchybill2;
                    break;
                case "monarchybill3":
                    longCitation.Text = string.Format("A Bill deposing the Caravaggio's from the Baustralian Imperial Throne and replacing them with the Timpson family, and for purposes connected therewith");
                    selectionLabel.Text = string.Format("Bill C71. Status: Failed.");
                    displayTextBox.SelectedText = Resources.monarchybill3;
                    break;
                case "monarchybill":
                    longCitation.Text = string.Format("Monarchy Bill");
                    selectionLabel.Text = string.Format("Monarchy Bill. Status: Failed.");
                    displayTextBox.SelectedText = "1st reading, bill C14, introduced by the Member of Parliament for Mild Pond, Sir Nick Sullivan.\r\n" + votes.details("monarchybill1") +
                                                  "\r\n2nd reading, bill C16, introduced by the Member of Parliament for Mild Pond, Sir Nick Sullivan.\r\n" + votes.details("monarchybill2") +
                                                  "\r\n3rd reading, bill C71, introduced by the Prime Minister, Sir Nick Sullivan.\r\n" + votes.details("monarchybill3");
                    break;
                #endregion
                #region Armed Forces Bill
                case "armedforcesbill1":
                    longCitation.Text = string.Format("A Bill to Regulate Membership in the Armed Forces Among Members of Parliament");
                    selectionLabel.Text = string.Format("Bill C6101. Status: Failed.");
                    displayTextBox.SelectedText = Resources.armedforcesbill1;
                    break;
                case "armedforcesbill2":
                    longCitation.Text = string.Format("A Bill to Regulate Membership in the Armed Forces Among Members of Parliament");
                    selectionLabel.Text = string.Format("Bill L622. Status: Failed.");
                    displayTextBox.SelectedText = Resources.armedforcesbill2;
                    break;
                /*case "armedforcesbill3":
                    longCitation.Text = string.Format("A Bill deposing the Caravaggio's from the Baustralian Imperial Throne and replacing them with the Timpson family, and for purposes connected therewith");
                    selectionLabel.Text = string.Format("Bill C71. Status: Failed.");
                    displayTextBox.SelectedText = Resources.armedforcesbill3;
                    break;*/
                case "armedforcesbill":
                    longCitation.Text = string.Format("Armed Forces Bill");
                    selectionLabel.Text = string.Format("Armed Forces Bill. Status: Pending.");
                    displayTextBox.SelectedText = "1st reading, bill C6101, introduced by the Prime Minister, Sir Charles Burgardt.\r\n" + votes.details("armedforcesbill1") +
                                                  "\r\n2nd reading, bill L622, introduced by the Shadow Secretary of State for Defence, the Duke of Northumbria.\r\n" + votes.details("armedforcesbill2") +
                                                  "\r\n3rd reading pending.";
                    break;
                #endregion
                #endregion
                default:
                    longCitation.Text = ""; displayTextBox.Clear(); selectionLabel.Text = "";
                    break;
            }
        }

        //Repealed by [citation] (name)
        //Repeals [citation]
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            displayTextBox.Clear();
            displayTextBox.SelectionHangingIndent = 48;
            getFrom(treeView1.SelectedNode.Name);
            toolStripTextBox1.Text = treeView1.SelectedNode.Name.ToLower();
        }
        public void formGen(int chapter, string monarch, int regnalYear, string status, Form figures)
        {
            figures.Show();
            longCitation.Text = string.Format(formats[3], AddOrdinal(chapter), AddOrdinal(regnalYear));
            selectionLabel.Text = string.Format(formats[2], regnalYear + " " + monarch, chapter, status);
        }
        public void formGen(int chapter, string monarch, int regnalYear, string status)
        {
            longCitation.Text = string.Format(formats[3], AddOrdinal(chapter), AddOrdinal(regnalYear));
            selectionLabel.Text = string.Format(formats[2], regnalYear + " " + monarch, chapter, status);
        }
        public static string AddOrdinal(int num)
        {
            if (num <= 0) return num.ToString();

            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }

            switch (num % 10)
            {
                case 1:
                    return num + "st";
                case 2:
                    return num + "nd";
                case 3:
                    return num + "rd";
                default:
                    return num + "th";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Replace imagelist icons with higher quality resource equivalents.
            listIcons.Images[0] = Resources.book;
            listIcons.Images[1] = Resources.bookOpen;
            listIcons.Images[2] = Resources.bookSelected;
            listIcons.Images[3] = Resources.failed;
            listIcons.Images[4] = Resources.in_force;
            listIcons.Images[5] = Resources.repealed;
            listIcons.Images[6] = Resources.spent;
            listIcons.Images[7] = Resources.amended;
            listIcons.Images[8] = Resources.opennew;
            listIcons.Images[9] = Resources.pending;
            listIcons.Images[10] = Resources.open;
            #endregion
            #region Extract help file to temp
            helpFilePath = Path.Combine(Path.GetTempPath(), "helpFile.chm");
            var Writer = new BinaryWriter(File.OpenWrite(helpFilePath));
            Writer.Write(Resources.help);
            Writer.Flush();
            Writer.Close();
            #endregion
            var assembly = Assembly.GetExecutingAssembly();
            versionLabel.Text = string.Format(versionLabel.Text, assembly.GetName().Version!.Major, assembly.GetName().Version!.Minor, assembly.GetName().Version!.Build);
            SquirrelAwareApp.HandleEvents(onEveryRun: OnAppRun);
        }

        private void OnAppRun(SemanticVersion version, IAppTools tools, bool firstRun)
        {
            tools.SetProcessAppUserModelId();
            UpdateApp(toolStripSplitButton1);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpFilePath);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
            displayTextBox.SelectionHangingIndent = 48;
            getFrom(toolStripTextBox1.Text);
        }

        private void expandAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void collapseAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void inForceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            foreach (TreeNode nodes in treeView1.Nodes)
            {
                for (int i = nodes.Nodes.Count - 1; i >= 0; i--)
                {
                    if (nodes.Nodes[i].ImageIndex != 4 && nodes.Nodes[i].ImageIndex != 7)
                    {
                        nodes.Nodes[i].Remove();
                    }
                }
            } /*Remove repealed, spent, destroyed, etc. Acts of Parliament*/
            for (int i = treeView1.Nodes.Count - 1; i >= 0; i--)
            {
                if (treeView1.Nodes[i].Nodes.Count == 0)
                {
                    treeView1.Nodes[i].Remove();
                }
            } /*Remove empty books*/
            treeView1.SelectedNode = treeView1.Nodes[0];
        }

        private void repealedOrSpentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            foreach (TreeNode nodes in treeView1.Nodes)
            {
                for (int i = nodes.Nodes.Count - 1; i >= 0; i--)
                {
                    if (nodes.Nodes[i].ImageIndex != 3 && nodes.Nodes[i].ImageIndex != 5 && nodes.Nodes[i].ImageIndex != 6 && nodes.Nodes[i].ImageIndex != 11)
                    {
                        nodes.Nodes[i].Remove();
                    }
                }
            } /*Remove in force, etc. Acts of Parliament*/
            for (int i = treeView1.Nodes.Count - 1; i >= 0; i--)
            {
                if (treeView1.Nodes[i].Nodes.Count == 0)
                {
                    treeView1.Nodes[i].Remove();
                }
            } /*Remove empty books*/
            treeView1.SelectedNode = treeView1.Nodes[0];
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            oobe _oobe = new oobe();
            _oobe.Show();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            UpdateApp(toolStripSplitButton1);
        }
    }
}