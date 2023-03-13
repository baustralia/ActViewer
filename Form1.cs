using ActViewer.Properties;

namespace ActViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] formats =
               {"The {0} chapter of the Statute of Parliament that sat during the {1} Year of the Reign of King John, {2}.",
                 "The full PDF copy can be downloaded here:",
                 "{0} c. {1}. Status: {2}",
                 "The {0} chapter of the Statute of Parliament that sat during the {1} Year of the Reign of King John."
                };

        string helpFilePath = String.Empty;

        //Repealed by [citation] (name)
        //Repeals [citation]
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            displayTextBox.Clear();
            displayTextBox.SelectionHangingIndent = 48;
            switch (treeView1.SelectedNode.Name)
            {
                #region 1 John 1
                case "1John1":
                    longCitation.Text = formats[1];
                    displayTextBox.SelectedText = "https://cdn.discordapp.com/attachments/1030010424424411137/1030014277198819328/1_John_1_as_originally_enacted.pdf";
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
                case "1john1c3original":
                    displayTextBox.SelectedText = Resources._1john1_3_original;
                    formGen(3, "John 1", 1, "Repealed");
                    break;
                case "1john1c3":
                    formGen(3, "John 1", 1, "Repealed");
                    displayTextBox.SelectedText = "Succession Law (Modifications) Act\r\nBy command of the King.\r\nRepealed by 2 John 1 c. 1 (Repeal Act).";
                    break;
                #endregion
                #endregion
                #region 2 John 1
                case "2John1":
                    longCitation.Text = formats[1];
                    displayTextBox.SelectedText = "https://cdn.discordapp.com/attachments/1030010424424411137/1030014564122759218/2_John_1_as_originally_enacted.pdf";
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
                case "2john1c2":
                    formGen(2, "John 1", 2, "Amended");
                    displayTextBox.SelectedText = "Constitution Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nAmended by:\r\n  2 John 1 c. 11 (Succession Law (Modifications, No. 2) Act).\r\n  2 John 1 c. 27 (Fixed Terms Election Act).\r\nNo vote counts avaliable.";
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
                    displayTextBox.SelectedText = "Dukedom of Northumbria Act\r\nBy command of the King.";
                    formGen(9, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 10
                case "2john1c10original":
                    displayTextBox.SelectedText = Resources._2john1_10_original;
                    formGen(10, "John 1", 2, "Spent");
                    break;
                case "2john1c10":
                    displayTextBox.SelectedText = "Fox Islands Act\r\nIntroduced by the Minister of Foreign Affairs, Sir Harrison Pickles.\r\nNo vote counts avaliable.";
                    formGen(10, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 11
                case "2john1c11amend1":
                    displayTextBox.SelectedText = Resources._2john1_11_amend1;
                    formGen(11, "John 1", 2, "Amended");
                    break;
                case "2john1c11original":
                    displayTextBox.SelectedText = Resources._2john1_11_original;
                    formGen(11, "John 1", 2, "Amended");
                    break;
                case "2john1c11":
                    displayTextBox.SelectedText = "Succession Law (Modifications, No. 2) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nRepeals 2 John 1 c. 4.\r\nAmends 2 John 1 c. 2.\r\nAmended by 3 John 1 c. 8 (Short Titles Act).\r\nNo vote counts avaliable.";
                    formGen(11, "John 1", 2, "Amended");
                    break;
                #endregion
                #region Chapter 12
                case "2john1c12original":
                    displayTextBox.SelectedText = Resources._2john1_12_original;
                    formGen(12, "John 1", 2, "In force");
                    break;
                case "2john1c12":
                    displayTextBox.SelectedText = "Citizenship Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    formGen(12, "John 1", 2, "In force");
                    break;
                #endregion
                #region Chapter 13
                case "2john1c13original":
                    displayTextBox.SelectedText = Resources._2john1_13_original;
                    formGen(13, "John 1", 2, "Spent");
                    break;
                case "2john1c13":
                    displayTextBox.SelectedText = "Kapreburg Act\r\nIntroduced by the Minister for Foreign Affairs, Sir Harrison Pickles.\r\nNo vote counts avaliable.";
                    formGen(13, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 14
                case "2john1c14original":
                    displayTextBox.SelectedText = Resources._2john1_14_original;
                    formGen(14, "John 1", 2, "Spent");
                    break;
                case "2john1c14":
                    displayTextBox.SelectedText = "Rmhoania Act\r\nIntroduced by the Minister for Foreign Affairs, Sir Harrison Pickles.\r\nNo vote counts avaliable.";
                    formGen(14, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 15
                case "2john1c15original":
                    displayTextBox.SelectedText = Resources._2john1_15_original;
                    formGen(15, "John 1", 2, "Spent");
                    break;
                case "2john1c15":
                    displayTextBox.SelectedText = "Air Force (No. 2) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nRepeals 2 John 1 c. 6.\r\nNo vote counts avaliable.";
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
                    displayTextBox.SelectedText = "Religion (Throne) Act\r\nBy command of the King.\r\nAmended by 2 John 1 c. 24 (Religion (Practice) Act).\r\nNo vote counts avaliable.";
                    formGen(16, "John 1", 2, "Amended");
                    break;
                #endregion
                #region Chapter 17
                case "2john1c17original":
                    displayTextBox.SelectedText = Resources._2john1_17_original;
                    formGen(17, "John 1", 2, "In force");
                    break;
                case "2john1c17":
                    displayTextBox.SelectedText = "Seperation Act\r\nBy command of the King.\r\nNo vote counts avaliable.";
                    formGen(17, "John 1", 2, "In force");
                    break;
                #endregion
                #region Chapter 18
                case "2john1c18original":
                    displayTextBox.SelectedText = Resources._2john1_18_original;
                    formGen(18, "John 1", 2, "Spent");
                    break;
                case "2john1c18":
                    displayTextBox.SelectedText = "Abdication Act\r\nBy command of the King.\r\nNo vote counts avaliable.";
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
                    formGen(21, "John 1", 2, "In force");
                    break;
                case "2john1c21":
                    displayTextBox.SelectedText = "Boerc Measures Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    formGen(21, "John 1", 2, "In force");
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
                    formGen(27, "John 1", 2, "In force");
                    break;
                case "2john1c27":
                    displayTextBox.SelectedText = "Fixed Terms Election Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nAmends 2 John 1 c. 2.\r\nNo vote counts avaliable.";
                    formGen(27, "John 1", 2, "In force");
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
                    displayTextBox.SelectedText = "Dominion (Legislation) Act\r\nBy command of the King.\r\nNo vote counts avaliable.";
                    formGen(29, "John 1", 2, "Spent");
                    break;
                #endregion
                #region Chapter 30
                case "2john1c30original":
                    displayTextBox.SelectedText = Resources._2john1_30_original;
                    formGen(30, "John 1", 2, "In force");
                    break;
                case "2john1c30":
                    displayTextBox.SelectedText = "Military Law Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    formGen(30, "John 1", 2, "In force");
                    break;
                #endregion
                #endregion
                #region 3 John 1
                case "3John1":
                    longCitation.Text = formats[1];
                    displayTextBox.SelectedText = "https://cdn.discordapp.com/attachments/1030010424424411137/1030014940515418152/3_John_1_as_originally_enacted.pdf";
                    selectionLabel.Text = "3 John 1";
                    break;
                #region Chapter 1
                case "3john1c1original":
                    formGen(1, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_1_original;
                    break;
                case "3john1c1":
                    formGen(1, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Cannabis Act (Legalization)\r\nIntroduced by the Deputy Prime Minister, Sir Harrison Pickles.\r\nRepeals 2 John 1 c. 8.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 2
                case "3john1c2original":
                    formGen(2, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_2_original;
                    break;
                case "3john1c2":
                    formGen(2, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Narcotics Act\r\nIntroduced by the Deputy Prime Minister, Sir Harrison Pickles.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 3
                case "3john1c3original":
                    formGen(3, "John 1", 3, "In force");
                    displayTextBox.SelectedText = Resources._3john1_3_original;
                    break;
                case "3john1c3":
                    formGen(3, "John 1", 3, "In force");
                    displayTextBox.SelectedText = "Informants Act (Wangatangia)\r\nIntroduced by the Prime Minister of Wangatangia, Lord Mayjames.\r\nNo vote counts avaliable.";
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
                    displayTextBox.SelectedText = "Concealed Firearms Act\r\nIntroduced by the Deputy Prime Minister, Sir Harrison Pickles.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 11
                case "3john1c11original":
                    formGen(11, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_11_original;
                    break;
                case "3john1c11":
                    formGen(11, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Wrythe Convention Act\r\nIntroduced by the Minister for Foreign Affairs, Sir Harrison Pickles.\r\nNo vote counts avaliable.";
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
                    formGen(13, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = Resources._3john1_13_original;
                    break;
                case "3john1c13":
                    formGen(13, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Union with Quebec (Modifications) Act (Baustralia)\r\nIntroduced by the Minister for Foreign Affairs, Sir Harrison Pickles.\r\nAmends 3 John 1 c. 9.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 14
                case "3john1c14original":
                    formGen(14, "John 1", 3, "In force");
                    //displayTextBox.SelectedText = Resources._3john1_14_original;
                    break;
                case "3john1c14":
                    formGen(14, "John 1", 3, "In force");
                    //displayTextBox.SelectedText = "Concealed Firearms Act\r\nIntroduced by the Deputy Prime Minister, Sir Harrison Pickles.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 15
                case "3john1c151original":
                    formGen(15, "John 1", 3, "Spent");
                    //displayTextBox.SelectedText = Resources._3john1_15_original;
                    break;
                case "3john1c15":
                    formGen(15, "John 1", 3, "Spent");
                    displayTextBox.SelectedText = "Wrythe Convention Act\r\nIntroduced by the Minister for Foreign Affairs, Sir Harrison Pickles.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #region Chapter 16
                case "3john1c16original":
                    formGen(16, "John 1", 3, "In force");
                    //displayTextBox.SelectedText = Resources._3john1_16_original;
                    break;
                case "3john1c16":
                    formGen(16, "John 1", 3, "In force");
                    //displayTextBox.SelectedText = "Acts of Parliament (Commencement) Act\r\nIntroduced by the Prime Minister, Sir John Timpson.\r\nNo vote counts avaliable.";
                    break;
                #endregion
                #endregion
                default:
                    longCitation.Text = ""; displayTextBox.Clear(); selectionLabel.Text = "";
                    break;
            }
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
    }
}