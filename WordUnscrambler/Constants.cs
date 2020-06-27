﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Constants
    {
        public const string ScrambledWordOptions = "Enter Scrambled Word(s) manually or as a file: F- file / M- manual";
        public const string ContinueProgramOptions = "Would you like to continue? Y/N";

        public const string EnterScrambledWordsViaFile = "Enter full path including the file name: ";
        public const string EnterScrambledWordsManually = "Enter word(s) manually separated by commas if multiple: ";

        public const string EnterScrambledWordsOptionNotRecognized = "The option was not recognized.";
        public const string ScrambledWordsCannotBeLoaded = "Scrambled words were not loaded because there was an error";
        public const string ErrorProgramTerminated = "The program will be terminanted.";

        public const string MatchFound = "Match found for {0}: {1}";
        public const string MatchNotFound = "No Matches found.";

        public const string Yes = "Y";
        public const string No = "N";

        public const string File = "F";
        public const string Manual = "M";

        public const string WordListFileName = "wordlist.txt";
    }
}
