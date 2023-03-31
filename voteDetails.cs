using System;

public class votes
{
	public static string details(string selector)
	{
        string[] results;
        switch (selector)
		{
            #region 6 John 1 c. 9
            case "6john1c9":
                results = new string[]
                    { "┌─────────────────┬─────────────────┬─────────────────┬─────────────────┐"
                ,     "│     LIBERAL     │   LIBERTARIAN   │   CONSERVATIVE  │    COMMUNIST    │"
                ,     "├─────────────────┴─────────────────┴─────────────────┴─────────────────┤"
                ,     "│                                  AYES                                 │"
                ,     "├─────────────────┬─────────────────┬─────────────────┬─────────────────┤"
                ,     "│A. Calero        │M. Hughes        │Sir N. Sullivan  │T. Jacobs        │"
                ,     "│Sir C. Burgardt  │                 │Lady E. Parker   │                 │"
                ,     "│S. FitzGibbons   │                 │Sir J. Gardner   │                 │"
                ,     "│                 │                 │Sir O. Doig      │                 │"
                ,     "│                 │                 │Sir J. Gardner   │                 │"
                ,     "│                 │                 │W. Perks         │                 │"
                ,     "│                 │                 │K. Paradis       │                 │"
                ,     "│                 │                 │B. Broersma      │                 │"
                ,     "└─────────────────┴─────────────────┴─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 13
            case "6john1c13":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│     LIBERAL     │   CONSERVATIVE  │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│A. Calero        │W. Perks         │"
                ,     "│Sir C. Burgardt  │R. McPhail       │"
                ,     "│S. FitzGibbons   │B. Broersma      │"
                ,     "│A. van der Bruyn │                 │"
                ,     "│M. Prasetia      │                 │"
                ,     "│M. Hughes        │                 │"
                ,     "│I. D. Smith II   │                 │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                NAYS               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│A. Lacey-Scott   │ T. Jacobs       │"
                ,     "│                 │ Sir O. Doig     │"
                ,     "│                 │ Lady E. Parker  │"
                ,     "│                 │ K. Paradis      │"
                ,     "│                 │ Sir N. Sullivan │"
                ,     "│                 │ Sir O. Doig     │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 14
            case "6john1c14":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│     LIBERAL     │   CONSERVATIVE  │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│A. Lacey-Scott   │B. Broersma      │"
                ,     "│A. van der Bruyn │R. McPhail       │"
                ,     "│A. Calero        │W. Perks         │"
                ,     "│C. Snyder        │                 │"
                ,     "│Sir C. Burgardt  │                 │"
                ,     "│M. Prasetia      │                 │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│            ABSTENTIONS            │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│S. FitzGibbons   │T. Jacobs        │"
                ,     "│L. Perry-Ardens  │                 │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 16
            case "6john1c16":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│     LIBERAL     │   CONSERVATIVE  │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│A. Lacey-Scott   │Sir. O. Doig     │"
                ,     "│C. Snyder        │R. McPhail       │"
                ,     "│L. Perry-Ardens  │W. Perks         │"
                ,     "│A. van der Bruyn │I. D. Smith II   │"
                ,     "│                 │T. Jacobs        │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 17
            case "6john1c17":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│     LIBERAL     │   CONSERVATIVE  │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│A. Calero        │T. Jacobs        │"
                ,     "│A. Lacey-Scott   │R. McPhail       │"
                ,     "│S. FitzGibbons   │                 │"
                ,     "│M. Prasetia      │                 │"
                ,     "│C. Snyder        │                 │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 18
            case "6john1c18":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│     LIBERAL     │   CONSERVATIVE  │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│Sir C. Burgardt  │R. McPhail       │"
                ,     "│C. Snyder        │I. D. Smith II   │"
                ,     "│M. Prasetia      │Sir O. Doig      │"
                ,     "│S. FitzGibbons   │                 │"
                ,     "│A. Calero        │                 │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 20
            case "6john1c20":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│Lady E. Parker   │L. Perry-Ardens  │"
                ,     "│W. Perks         │S. FitzGibbons   │"
                ,     "│B. Broersma      │C. Snyder        │"
                ,     "│R. McPhail       │                 │"
                ,     "│I. D. Smith II   │                 │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 21
            case "6john1c21":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│W. Perks         │M. Prasetia      │"
                ,     "│R. McPhail       │A. Lacey-Scott   │"
                ,     "│B. Broersma      │C. Snyder        │"
                ,     "│                 │A. Calero        │"
                ,     "│                 │L. Perry-Ardens  │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                NAYS               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│I. D. Smith II   │                 │"
                ,     "│T. Jacobs        │                 │"
                ,     "│Sir O. Doig      │                 │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 22
            case "6john1c22":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│Sir O. Doig      │L. Perry-Ardens  │"
                ,     "│I. D. Smith II   │S. FitzGibbons   │"
                ,     "│W. Perks         │                 │"
                ,     "│Sir J. Gardner   │                 │"
                ,     "│B. Broersma      │                 │"
                ,     "│R. McPhail       │                 │"
                ,     "│T. Jacobs        │                 │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                NAYS               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│                 │M. Prasetia      │"
                ,     "│                 │Sir C. Burgardt  │"
                ,     "│                 │C. Snyder        │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 23
            case "6john1c23":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│R. McPhail       │L. Perry-Ardens  │"
                ,     "│B. Broersma      │A. Lacey-Scott   │"
                ,     "│                 │A. Calero        │"
                ,     "│                 │C. Snyder        │"
                ,     "│                 │S. FitzGibbons   │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                NAYS               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│                 │M. Prasetia      │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│            ABSTENTIONS            │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│T. Jacobs        │                 │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 24
            case "6john1c24":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│Sir J. Gardner   │C. Snyder        │"
                ,     "│R. McPhail       │L. Perry-Ardens  │"
                ,     "│B. Broersma      │A. Lacey-Scott   │"
                ,     "│W. Perks         │                 │"
                ,     "│T. Jacobs        │                 │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                NAYS               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│                 │M. Prasetia      │"
                ,     "│                 │A. Calero        │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 25
            case "6john1c25":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│Sir O. Doig      │A. Lacey-Scott   │"
                ,     "│B. Broersma      │A. Calero        │"
                ,     "│R. McPhail       │L. Perry-Ardens  │"
                ,     "│T. Jacobs        │                 │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                NAYS               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│                 │M. Prasetia      │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│            ABSTENTIONS            │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│                 │Sir C. Burgardt  │"
                ,     "│                 │S. FitzGibbons   │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 26
            case "6john1c26":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│Lady E. Parker   │A. Lacey-Scott   │"
                ,     "│R. McPhail       │C. Snyder        │"
                ,     "│T. Jacobs        │A. Calero        │"
                ,     "│B. Broersma      │L. Perry-Ardens  │"
                ,     "│                 │M. Hughes        │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 30
            case "6john1c30":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│Sir O. Doig      │A. Lacey-Scott   │"
                ,     "│T. Jacobs        │L. Perry-Ardens  │"
                ,     "│R. McPhail       │                 │"
                ,     "│B. Broersma      │                 │"
                ,     "│M. Prasetia      │                 │"
                ,     "│Sir J. Gardner   │                 │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                NAYS               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│                 │A. Calero        │"
                ,     "│                 │Sir C. Burgardt  │"
                ,     "│                 │S. FitzGibbons   │"
                ,     "│                 │C. Snyder        │"
                ,     "│                 │M. Hughes        │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 32
            case "6john1c32":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│Sir O. Doig      │Sir C. Burgardt  │"
                ,     "│R. McPhail       │C. Snyder        │"
                ,     "│T. Jacobs        │A. Lacey-Scott   │"
                ,     "│M. Prasetia      │                 │"
                ,     "│B. Broersma      │                 │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                NAYS               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│                 │A. Calero        │"
                ,     "│                 │S. FitzGibbons   │"
                ,     "│                 │L. Perry-Ardens  │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 33
            case "6john1c33":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│T. Jacobs        │                 │"
                ,     "│R. McPhail       │                 │"
                ,     "│B. Broersma      │                 │"
                ,     "│Sir J. Gardner   │                 │"
                ,     "│M. Prasetia      │                 │"
                ,     "│Sir O. Doig      │                 │"
                ,     "│Sir J. Timpson   │                 │"
                ,     "│W. Perks         │                 │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                NAYS               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│                 │Sir C. Burgardt  │"
                ,     "│                 │A. Calero        │"
                ,     "│                 │C. Snyder        │"
                ,     "│                 │S. FitzGibbons   │"
                ,     "│                 │L. Perry-Ardens  │"
                ,     "│                 │M. Hughes        │"
                ,     "│                 │A. Lacey-Scott   │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 34
            case "6john1c34":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│T. Jacobs        │A. Calero        │"
                ,     "│B. Broersma      │M. Hughes        │"
                ,     "│M. Prasetia      │A. Lacey-Scott   │"
                ,     "│Sir J. Gardner   │C. Snyder        │"
                ,     "│Sir O. Doig      │                 │"
                ,     "│Sir J. Timpson   │                 │"
                ,     "│W. Perks         │                 │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 36
            case "6john1c36":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│T. Jacobs        │A. Lacey-Scott   │"
                ,     "│Sir O. Doig      │M. Hughes        │"
                ,     "│B. Broersma      │                 │"
                ,     "│Sir J. Gardner   │                 │"
                ,     "│W. Perks         │                 │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                NAYS               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│M. Prasetia      │Sir C. Burgardt  │"
                ,     "│                 │C. Snyder        │"
                ,     "│                 │L. Perry-Ardens  │"
                ,     "│                 │S. FitzGibbons   │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│            ABSTENTIONS            │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│                 │A. Calero        │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region 6 John 1 c. 39
            case "6john1c39":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│Sir O. Doig      │L. Perry-Ardens  │"
                ,     "│M. Prasetia      │A. Calero        │"
                ,     "│                 │A. Lacey-Scott   │"
                ,     "│                 │M. Hughes        │"
                ,     "│                 │Sir C. Burgardt  │"
                ,     "│                 │C. Snyder        │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion

            #region Monarchy Bill (1st Reading)
            case "monarchybill1":
                results = new string[]
                    { "┌─────────────────┬─────────────────┬─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │    SOCIALIST    │    WORKER'S     │   INDEPENDANT   │"
                ,     "├─────────────────┴─────────────────┴─────────────────┴─────────────────┤"
                ,     "│                                 AYES                                  │"
                ,     "├─────────────────┬─────────────────┬─────────────────┬─────────────────┤"
                ,     "│                 │Lady E. Day      │                 │Sir N. Sullivan  │"
                ,     "├─────────────────┴─────────────────┴─────────────────┴─────────────────┤"
                ,     "│                                 NAYS                                  │"
                ,     "├─────────────────┬─────────────────┬─────────────────┬─────────────────┤"
                ,     "│Sir J. Timpson   │                 │Sir O. Doig      │                 │"
                ,     "│Harrison Pickles │                 │                 │                 │"
                ,     "└─────────────────┴─────────────────┴─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region Monarchy Bill (2nd Reading)
            case "monarchybill2":
                results = new string[]
                    { "┌─────────────────┬─────────────────┬─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │    SOCIALIST    │    WORKER'S     │   INDEPENDANT   │"
                ,     "├─────────────────┴─────────────────┴─────────────────┴─────────────────┤"
                ,     "│                                 AYES                                  │"
                ,     "├─────────────────┬─────────────────┬─────────────────┬─────────────────┤"
                ,     "│                 │Lady E. Day      │                 │Sir N. Sullivan  │"
                ,     "├─────────────────┴─────────────────┴─────────────────┴─────────────────┤"
                ,     "│                                 NAYS                                  │"
                ,     "├─────────────────┬─────────────────┬─────────────────┬─────────────────┤"
                ,     "│Sir J. Timpson   │                 │Sir O. Doig      │K. Paradis       │"
                ,     "│Harrison Pickles │                 │                 │                 │"
                ,     "│Sir G. Watts     │                 │                 │                 │"
                ,     "└─────────────────┴─────────────────┴─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region Monarchy Bill (3rd Reading)
            case "monarchybill3":
                results = new string[]
                    { "┌─────────────────┬─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │   INDEPENDANT   │"
                ,     "├─────────────────┴─────────────────┴─────────────────┤"
                ,     "│                        NAYS                         │"
                ,     "├─────────────────┬─────────────────┬─────────────────┤"
                ,     "│Sir N. Sullivan  │Sir C. Burgardt  │Aidan McGrath    │"
                ,     "│Sir O. Doig      │                 │                 │"
                ,     "│Lady Flavora     │                 │                 │"
                ,     "│Lord Simpson     │                 │                 │"
                ,     "│Lord Wooler      │                 │                 │"
                ,     "└─────────────────┴─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region Armed Forces Bill (1st Reading)
            case "armedforcesbill1":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│                 │Sir C. Burgardt  │"
                ,     "│                 │C. Snyder        │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                NAYS               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│Sir O. Doig      │I. D. Smith II   │"
                ,     "│W. Perks         │L. Perry-Ardens  │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│            ABSTENTIONS            │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│T. Jacobs        │A. Lacey-Scott   │"
                ,     "│                 │A. Calero        │"
                ,     "│                 │S. FitzGibbons   │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            #region Armed Forces Bill (2nd Reading)
            case "armedforcesbill2":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                AYES               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│                 │A. Calero        │"
                ,     "│                 │S. FitzGibbons   │"
                ,     "│                 │C. Snyder        │"
                ,     "│                 │L. Perry-Ardens  │"
                ,     "│                 │Sir C. Burgardt  │"
                ,     "│                 │M. Hughes        │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                NAYS               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│M. Prasetia      │A. van der Bruyn |"
                ,     "│R. McPhail       │                 │"
                ,     "│Sir O. Doig      │                 │"
                ,     "│B. Broersma      │                 │"
                ,     "│T. Jacobs        │                 │"
                ,     "│Sir J. Gardner   │                 │"
                ,     "│W. Perks         │                 |"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│            ABSTENTIONS            │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│                 │A. Lacey-Scott   │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion
            /*#region Armed Forces Bill (3rd Reading)
            case "armedforcesbill3":
                results = new string[]
                    { "┌─────────────────┬─────────────────┐"
                ,     "│   CONSERVATIVE  │     LIBERAL     │"
                ,     "├─────────────────┴─────────────────┤"
                ,     "│                NAYS               │"
                ,     "├─────────────────┬─────────────────┤"
                ,     "│Sir N. Sullivan  │Sir C. Burgardt  │"
                ,     "│Sir O. Doig      │                 │"
                ,     "│Lady Flavora     │                 │"
                ,     "│Lord Simpson     │                 │"
                ,     "│Lord Wooler      │                 │"
                ,     "└─────────────────┴─────────────────┘"};
                return string.Join("\r\n", results);
            #endregion*/
            default:
                return "";
        }
    }
}
