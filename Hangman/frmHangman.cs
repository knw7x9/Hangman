// frm.cs, ConwaysGameOfLife.sln
// CS 1181
// Katherine Wilsdon
// 13 November 2018
// Dr. Cody Permann

/* Description - Create Hangman. The user picks a file containing a list of words and the length of the word. 
 * The list of words is read from the file and the program randomly selects a word of the appropriate length and the 
 * game begins. The player guesses a letter and either the letter is revealed in the word or the user is informed
 * that the letter is not in the owrd. The letter is added to the list of previous guess and the user is informed if 
 * the player repeated a guess. The program determines if the player has won or lost. */

/* WOW: 
 * 1. Created a jagged array that is sorted the the length of the word.
 * 2. Drew the hangman depending on the length of the word and the number of guesses */

/* Cited:
 * Seed generation for random number generator: https://stackoverflow.com/questions/1785744/how-do-i-seed-a-random-class-to-avoid-getting-duplicate-random-values
 * Jagged Array https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays
 * Modifying individual characters https://docs.microsoft.com/en-us/dotnet/csharp/how-to/modify-string-contents
 * Clear the combobox https://stackoverflow.com/questions/9321844/how-do-i-clear-a-combobox
 * Clear a character https://stackoverflow.com/questions/3670505/why-is-there-no-char-empty-like-string-empty
 * Clear a listbox https://stackoverflow.com/questions/6442098/how-to-clear-all-data-in-a-listbox
 * Book, Chapters 5, 6, 7, and 8: Gaddis, T. (2017). Starting out with Visual C# (4th ed.). Boston, PA: Pearson.*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hangman {
    public partial class frmHangman : Form {
        public frmHangman() {
            InitializeComponent();

        }
        // Declare field variables
        private string[] _wordList;        
        private string[][] _sortedWordList;
        private char[] _word;              
        private int _maxLength;
        private int _lengthOfWord;
        private int _maxGuesses;
        private int _guessNumber = 0;
        private int _sizeWordList;
        private char _guessedLetter;
        private string _guessedWord = "";
        private Random random = new Random(Guid.NewGuid().GetHashCode());        

        /// <summary>
        /// Opens a file dialog to pick a text file and inputs the path to a textbox
        /// </summary>
        private void PopulateWordFileTextbox() {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Adds the option to view all files or just text files
            openFileDialog.Filter = "text file(*.txt)|*.txt|All files|*.*";

            // When the user clicks the open button, the path is inputted into a textbox
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                txtInputWordFile.Text = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Create a string array with each word in the text file
        /// </summary>
        private void LoadFile() {
            try {
                _wordList = File.ReadAllLines(txtInputWordFile.Text);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);                
            }
        }              

        /// <summary>
        /// Initialize field variables
        /// </summary>
        private void InitializeFieldVariables() {
            _sizeWordList = _wordList.Length;            
            _maxLength = _wordList[0].Length;
            //Replace maxLength with the longest length of a word
            for (int i = 0; i < _wordList.Length; i++) {
                if (_wordList[i].Length > _maxLength) {
                    _maxLength = _wordList[i].Length;
                }
            }
        }

        /// <summary>
        /// Creates a count array of each word length in the wordList
        /// </summary>
        /// <returns>a count array each word length of wordList</returns>
        private int[] CountNumWords() {
            // Creates an array from 0 to 10
            int[] numWords = new int[_maxLength + 1];
            for (int i = 0; i < _sizeWordList; i++) {
                // Adds 1 at the index of numWords depending on word length of an item in wordlist
                numWords[_wordList[i].Length]++;
            }
            return numWords;
        }

        /// <summary>
        /// Create a jagged array sorted by the length of the word
        /// </summary>
        private void JaggedArray() {
            // Store the count array in a local array
            int[] numWords = CountNumWords();
            
            // Creates a jagged array from 0 to 10
            _sortedWordList = new string[_maxLength + 1][];

            // Initializes the entries of the jagged array using the count array
            for (int i = 0; i < _maxLength + 1; i++) {
                _sortedWordList[i] = new string[numWords[i]];
            }

            // Adds the word in wordList to the jagged array
            for (int i = 0; i < _maxLength + 1; i++) {
                int count = 0;
                for (int j = 0; j < _sizeWordList; j++) {
                    if (_wordList[j].Length == i) {
                        _sortedWordList[i][count] = _wordList[j];
                        count++;
                    }
                }
            }
        }

        
        /// <summary>
        /// Initialize the lengthOfWord
        /// </summary>
        /// <returns>the length of the word</returns>
        private int InitializeLengthOfWord() {
            string lengthOfWord = cmbHowManyLetters.SelectedItem.ToString();
            int.TryParse(lengthOfWord, out int _lengthOfWord);
            return _lengthOfWord;                             
        }
        
        /// <summary>
        /// Initialize maxGuesses
        /// </summary>
        /// <returns>the maximum Guesses</returns>
        private int InitializeMaxGuesses() {
            _maxGuesses = _lengthOfWord + 3;
            return _maxGuesses;
        }

        /// <summary>
        /// Chooses a word from the jagged array
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private string GetRandomWord(int length) {
            string word = "";
            int randomNum;

            // Store the count array in a local array
            int[] numWords = CountNumWords();

            // Select a random number between 0 and the given length in the count array
            randomNum = random.Next(numWords[length]);

            // Choose a word in the jagged array at the given length and the random number
            word = _sortedWordList[length][randomNum];            
            return word;
        }

        /// <summary>
        /// Outputs the asterisked word on the GUI
        /// </summary>
        private void DrawWord() {
            // Gets the word
            string word = GetRandomWord(_lengthOfWord);

            //Initialize the word array
            _word = new char[_lengthOfWord];

            //Store the local variable word in the word array and asterisks in th guessedWord array
            for (int i = 0; i < _lengthOfWord; i++) {               
                _word[i] = word[i];
                _guessedWord += "*";               
            }

            //Outputs to the GUI
            txtWord.Text = _guessedWord;
            lblOutputSayings.Text = "Start Guessing!";
        }

        /// <summary>
        /// Initialize GuessedLetter
        /// </summary>
        /// <returns></returns>
        private char InitializeGuessedLetter() {
            string guessedLetter = cmbLetters.SelectedItem.ToString();
            char.TryParse(guessedLetter, out char _guessedLetter);
            return _guessedLetter;
        }

        /// <summary>
        /// Validate that user does not duplicate a letter
        /// </summary>
        private void ValidateNoDuplicates() {
            if (lbGuessedLetters.Items.Contains(_guessedLetter)) {
                MessageBox.Show("The letter '" + _guessedLetter.ToString() + "' was already guessed.");
            }
        }

        /// <summary>
        /// Checks the word for the guessed letter and replaces the asterisk with the letter if found
        /// </summary>
        private void CheckWord() {
            // Create a character array
            char[] guessedWordAsChars = _guessedWord.ToCharArray();

            int count = 0;
            for (int i = 0; i < _lengthOfWord; i++) {
                // Replace the asterisk with the guessed letter and count the number of replacements 
                if (_guessedLetter == _word[i]) {
                    guessedWordAsChars[i] = _guessedLetter;
                    count++;
                }
            }
            // Convert the character array to guessedWord and output to the GUI
            _guessedWord = new string(guessedWordAsChars);
            txtWord.Text = _guessedWord;
            lbGuessedLetters.Items.Add(_guessedLetter);          
            for (int i = 0; i < _lengthOfWord; i++) {
                // Outputs the saying depending on if the word contains 1 or more correct letters
                if (guessedWordAsChars[i] == _guessedLetter) {
                    if (count >= 2) {
                        lblOutputSayings.Text = "The word contains " + count + " " + _guessedLetter + "'s";
                    } else if (count == 1) {
                        lblOutputSayings.Text = "The word contains " + count + " " + _guessedLetter;
                    }
                    break;
                } else {
                    // Outputs try again if incorrect
                    lblOutputSayings.Text = "Try again";
                }
            }
            // Adds 1 to the guess number if incorrect
            if (lblOutputSayings.Text == "Try again") {
                _guessNumber++;
            }
        }

        /// <summary>
        /// Determines if the player has won or lost
        /// </summary>
        private void WinLose() {
            string word = "";
            // Creates a local variable word for the word array
            for (int i = 0; i < _word.Length; i++) {                
                word += _word[i];
            }
            // Outputs the word and if the player has won or lost
            if (word == _guessedWord && _guessNumber < _maxGuesses) {
                lblOutputSayings.Text = "You've won!";
                lblWord.Text = "The word was " + word;
            } else if (_guessNumber == _maxGuesses) {
                lblOutputSayings.Text = "You lose.";
                lblWord.Text = "The word was " + word;
            }

        }

        /// <summary>
        /// Clears the field variables
        /// </summary>
        private void ClearFieldVariables() {            
            _word = null;                        
            _maxGuesses = 0;
            _guessNumber = 0;           
            _guessedLetter = '\0';
            _guessedWord = "";
        }

        /// <summary>
        /// Clears the arrays and some field variables
        /// </summary>
        private void ClearArrays() {
            _wordList = null;
            _sortedWordList = null;
            _sizeWordList = 0;
            _lengthOfWord = 0;
            _maxLength = 0;
        }

        /// <summary>
        /// Clears the how many letters combobox
        /// </summary>
        private void ClearHowManyLettersComboBox() {
            cmbHowManyLetters.SelectedIndex = -1;
        }

        /// <summary>
        /// Clears the letters combobox
        /// </summary>
        private void ClearLettersComboBox() {
            cmbLetters.SelectedIndex = -1;
        }

        /// <summary>
        /// Clears the word file textbox
        /// </summary>
        private void ClearInputWordFile() {
            txtInputWordFile.Text = "";
        }

        /// <summary>
        /// Clears the labels, textbox, and listbox
        /// </summary>
        private void ClearLabelsTextboxAndListbox() {
            lbGuessedLetters.Items.Clear();
            lblOutputSayings.Text = "";
            lblWord.Text = "";
            txtWord.Text = "";
        }

        /// <summary>
        /// Clears the hangman
        /// </summary>
        private void ClearHangman() {
            pbTop.Visible = false;
            pbDiagonal.Visible = false;
            pbVertical.Visible = false;
            pbStandLeft.Visible = false;
            pbStandRight.Visible = false;
            pbStandMiddle.Visible = false;
            pbNoose.Visible = false;
            pbHead.Visible = false;
            pbBody.Visible = false;
            pbLeftArm.Visible = false;
            pbRightArm.Visible = false;
            pbLeftLeg.Visible = false;
            pbRightLeg.Visible = false;
            
        }
        
        /// <summary>
        /// Clears the GUI to start the game again
        /// </summary>
        private void ClearStartGame() {
            ClearFieldVariables();
            ClearLettersComboBox();
            ClearLabelsTextboxAndListbox();
            ClearHangman();
        }

        /// <summary>
        /// Creates an error message when the wordFile textbox is empty
        /// </summary>
        private void ValidateBrowse() {
            string errorMessage = "";
            if (txtInputWordFile.Text == "") {
                errorMessage += "Word File Error: Select a word file.";
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Creates an error message when the wordFile textbox or the howManyLetters combobox is empty
        /// </summary>
        private void ValidateStartGame() {
            string errorMessage = "";
            if (txtInputWordFile.Text == "") {
                errorMessage += "Word File Error: Select a word file.\r\n";
            }
            if (cmbHowManyLetters.SelectedIndex == -1) {
                errorMessage += "ComboBox Error: Select the length of the word.";
            }
            if (txtInputWordFile.Text == "" || cmbHowManyLetters.SelectedIndex == -1) {
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Creates an error message with the letter combobox is empty
        /// </summary>
        private void ValidateGuesses() {
            string errorMessage = "";
            if (cmbLetters.SelectedIndex == -1) {
                errorMessage += "ComboBox Error: Guess a letter.";
                MessageBox.Show(errorMessage);
            }                           
        }
      
        /// <summary>
        /// The Browse method calls
        /// </summary>
        private void BrowseMain() {
            PopulateWordFileTextbox();
            ValidateBrowse();
            if (!(txtInputWordFile.Text == "")) {                
                LoadFile();                                      
                InitializeFieldVariables();
                JaggedArray();
            }
        }

        /// <summary>
        /// The Play Game method calls
        /// </summary>
        private void PlayGameMain() {
            ClearStartGame();
            ValidateStartGame();
            if (!(txtInputWordFile.Text == "" || cmbHowManyLetters.SelectedIndex == -1)) {
                _lengthOfWord = InitializeLengthOfWord();
                _maxGuesses = InitializeMaxGuesses();
                GetRandomWord(_lengthOfWord);
                DrawWord();
            }
        }

        /// <summary>
        /// The Guess method calls
        /// </summary>
        private void GuessMain() {
            ValidateGuesses();
            if (!(cmbLetters.SelectedIndex == -1)) {
                _guessedLetter = InitializeGuessedLetter();
                ValidateNoDuplicates();
                if (!(lbGuessedLetters.Items.Contains(_guessedLetter))) {
                    CheckWord();
                    HangmanMain();
                }
                WinLose();
            }
        }

        /// <summary>
        /// The Clear method calls
        /// </summary>
        private void ClearMain() {
            ClearFieldVariables();
            ClearArrays();
            ClearHowManyLettersComboBox();
            ClearLettersComboBox();
            ClearInputWordFile();
            ClearLabelsTextboxAndListbox();
            ClearHangman();
        }

        /// <summary>
        /// The Hangman method calls
        /// </summary>
        private void HangmanMain() {
            Hangman3Letters();
            Hangman4Letters();
            Hangman5Letters();
            Hangman6Letters();
            Hangman7Letters();
            Hangman8Letters();
            Hangman9Letters();
            Hangman10Letters();
        }

        /// <summary>
        /// Opens a file dialog and creates a jagged array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e) {
            BrowseMain();
        }

        /// <summary>
        /// Chooses a random word at the given length and outputs the asterisks of the word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartGame_Click(object sender, EventArgs e) {
            PlayGameMain();
        }

        /// <summary>
        /// Check the word for the guessed letter and outputs the results to the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuess_Click(object sender, EventArgs e) {
            GuessMain();
        }

        /// <summary>
        /// Clears the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e) {
            ClearMain();
        }

        /// <summary>
        /// Exits the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Builds the Hangman for a 3 letter word
        /// </summary>
        private void Hangman3Letters() {
            if (_lengthOfWord == 3) {
                if (_guessNumber == 1) {
                    pbTop.Visible = true;
                    pbDiagonal.Visible = true;
                    pbVertical.Visible = true;
                    pbStandLeft.Visible = true;
                    pbStandRight.Visible = true;
                    pbStandMiddle.Visible = true;
                    pbVertical.BringToFront();
                    pbStandMiddle.BringToFront();                   
                    pbStandRight.BringToFront();
                    pbDiagonal.BringToFront();                    
                } else if (_guessNumber == 2) {
                    pbNoose.Visible = true;
                    pbNoose.BringToFront();
                } else if (_guessNumber == 3) {
                    pbHead.Visible = true;                    
                } else if (_guessNumber == 4) {
                    pbBody.Visible = true;
                    pbBody.BringToFront();
                } else if (_guessNumber == 5) {
                    pbLeftArm.Visible = true;
                    pbRightArm.Visible = true;
                    pbLeftArm.BringToFront();                   
                    pbBody.BringToFront();
                    pbRightArm.BringToFront();
                } else if (_guessNumber == 6) {
                    pbLeftLeg.Visible = true;
                    pbRightLeg.Visible = true;
                    pbLeftLeg.BringToFront();
                    pbRightLeg.BringToFront();
                }
            }
        }

        /// <summary>
        /// Builds the Hangman for a 4 letter word
        /// </summary>
        private void Hangman4Letters() {
            if (_lengthOfWord == 4) {
                if (_guessNumber == 1) {
                    pbTop.Visible = true;
                    pbDiagonal.Visible = true;
                    pbVertical.Visible = true;
                    pbStandLeft.Visible = true;
                    pbStandRight.Visible = true;
                    pbStandMiddle.Visible = true;
                    pbVertical.BringToFront();
                    pbStandMiddle.BringToFront();
                    pbStandRight.BringToFront();
                    pbDiagonal.BringToFront();
                } else if (_guessNumber == 2) {
                    pbNoose.Visible = true;
                    pbNoose.BringToFront();
                } else if (_guessNumber == 3) {
                    pbHead.Visible = true;
                } else if (_guessNumber == 4) {
                    pbBody.Visible = true;
                    pbBody.BringToFront();
                } else if (_guessNumber == 5) {
                    pbLeftArm.Visible = true;
                    pbRightArm.Visible = true;
                    pbLeftArm.BringToFront();
                    pbBody.BringToFront();
                    pbRightArm.BringToFront();
                } else if (_guessNumber == 6) {
                    pbLeftLeg.Visible = true;
                    pbLeftLeg.BringToFront();
                } else if (_guessNumber == 7) {
                    pbRightLeg.Visible = true;
                    pbRightLeg.BringToFront();
                }
            }
        }

        /// <summary>
        /// Builds the Hangman for a 5 letter word
        /// </summary>
        private void Hangman5Letters() {
            if (_lengthOfWord == 5) {
                if (_guessNumber == 1) {
                    pbTop.Visible = true;
                    pbDiagonal.Visible = true;
                    pbVertical.Visible = true;
                    pbStandLeft.Visible = true;
                    pbStandRight.Visible = true;
                    pbStandMiddle.Visible = true;
                    pbVertical.BringToFront();
                    pbStandMiddle.BringToFront();
                    pbStandRight.BringToFront();
                    pbDiagonal.BringToFront();
                } else if (_guessNumber == 2) {
                    pbNoose.Visible = true;
                    pbNoose.BringToFront();
                } else if (_guessNumber == 3) {
                    pbHead.Visible = true;
                } else if (_guessNumber == 4) {
                    pbBody.Visible = true;
                    pbBody.BringToFront();
                } else if (_guessNumber == 5) {
                    pbLeftArm.Visible = true;
                    pbLeftArm.BringToFront();
                    pbBody.BringToFront();
                } else if (_guessNumber == 6) {
                    pbRightArm.Visible = true;
                    pbRightArm.BringToFront();
                } else if (_guessNumber == 7) {
                    pbLeftLeg.Visible = true;
                    pbLeftLeg.BringToFront();
                } else if (_guessNumber == 8) {
                    pbRightLeg.Visible = true;
                    pbRightLeg.BringToFront();
                }
            }
        }

        /// <summary>
        /// Builds the Hangman for a 6 letter word
        /// </summary>
        private void Hangman6Letters() {
            if (_lengthOfWord == 6) {
                if (_guessNumber == 1) {
                    pbVertical.Visible = true;
                    pbStandLeft.Visible = true;
                    pbStandRight.Visible = true;
                    pbStandMiddle.Visible = true;
                    pbVertical.BringToFront();
                    pbStandMiddle.BringToFront();
                    pbStandRight.BringToFront();                    
                } else if (_guessNumber == 2) {
                    pbTop.Visible = true;
                    pbDiagonal.Visible = true;
                    pbDiagonal.BringToFront();
                } else if (_guessNumber == 3) {
                    pbNoose.Visible = true;
                    pbNoose.BringToFront();
                } else if (_guessNumber == 4) {
                    pbHead.Visible = true;
                } else if (_guessNumber == 5) {
                    pbBody.Visible = true;
                    pbBody.BringToFront();
                } else if (_guessNumber == 6) {
                    pbLeftArm.Visible = true;
                    pbLeftArm.BringToFront();
                    pbBody.BringToFront();
                } else if (_guessNumber == 7) {
                    pbRightArm.Visible = true;
                    pbRightArm.BringToFront();
                } else if (_guessNumber == 8) {
                    pbLeftLeg.Visible = true;
                    pbLeftLeg.BringToFront();
                } else if (_guessNumber == 9) {
                    pbRightLeg.Visible = true;
                    pbRightLeg.BringToFront();
                }
            }
        }

        /// <summary>
        /// Builds the Hangman for a 7 letter word
        /// </summary>
        private void Hangman7Letters() {
            if (_lengthOfWord == 7) {
                if (_guessNumber == 1) {
                    pbVertical.Visible = true;
                    pbStandLeft.Visible = true;
                    pbStandRight.Visible = true;
                    pbStandMiddle.Visible = true;
                    pbVertical.BringToFront();
                    pbStandMiddle.BringToFront();
                    pbStandRight.BringToFront();                    
                } else if (_guessNumber == 2) {
                    pbDiagonal.Visible = true;
                    pbDiagonal.BringToFront();
                } else if (_guessNumber == 3) {
                    pbTop.Visible = true;
                } else if (_guessNumber == 4) {
                    pbNoose.Visible = true;
                    pbNoose.BringToFront();
                } else if (_guessNumber == 5) {
                    pbHead.Visible = true;
                } else if (_guessNumber == 6) {
                    pbBody.Visible = true;
                    pbBody.BringToFront();
                } else if (_guessNumber == 7) {
                    pbLeftArm.Visible = true;
                    pbLeftArm.BringToFront();
                    pbBody.BringToFront();
                } else if (_guessNumber == 8) {
                    pbRightArm.Visible = true;
                    pbRightArm.BringToFront();
                } else if (_guessNumber == 9) {
                    pbLeftLeg.Visible = true;
                    pbLeftLeg.BringToFront();
                } else if (_guessNumber == 10) {
                    pbRightLeg.Visible = true;
                    pbRightLeg.BringToFront();
                }
            }
        }

        /// <summary>
        /// Builds the Hangman for a 8 letter word
        /// </summary>
        private void Hangman8Letters() {
            if (_lengthOfWord == 8) {
                if (_guessNumber == 1) {
                    pbVertical.Visible = true;                   
                } else if (_guessNumber == 2) {                  
                    pbStandLeft.Visible = true;
                    pbStandRight.Visible = true;
                    pbStandMiddle.Visible = true;
                    pbVertical.BringToFront();
                    pbStandMiddle.BringToFront();
                    pbStandRight.BringToFront();
                } else if (_guessNumber == 3) {
                    pbDiagonal.Visible = true;
                    pbDiagonal.BringToFront();
                } else if (_guessNumber == 4) {
                    pbTop.Visible = true;
                } else if (_guessNumber == 5) {
                    pbNoose.Visible = true;
                    pbNoose.BringToFront();
                } else if (_guessNumber == 6) {
                    pbHead.Visible = true;
                } else if (_guessNumber == 7) {
                    pbBody.Visible = true;
                    pbBody.BringToFront();
                } else if (_guessNumber == 8) {
                    pbLeftArm.Visible = true;
                    pbLeftArm.BringToFront();
                    pbBody.BringToFront();
                } else if (_guessNumber == 9) {
                    pbRightArm.Visible = true;
                    pbRightArm.BringToFront();
                } else if (_guessNumber == 10) {
                    pbLeftLeg.Visible = true;
                    pbLeftLeg.BringToFront();
                } else if (_guessNumber == 11) {
                    pbRightLeg.Visible = true;
                    pbRightLeg.BringToFront();
                }
            }
        }

        /// <summary>
        /// Builds the Hangman for a 9 letter word
        /// </summary>
        private void Hangman9Letters() {
            if (_lengthOfWord == 9) {
                if (_guessNumber == 1) {
                    pbVertical.Visible = true;
                    pbStandMiddle.Visible = true;
                    pbVertical.BringToFront();
                    pbStandMiddle.BringToFront();
                    pbStandRight.BringToFront();
                } else if (_guessNumber == 2) {
                    pbStandLeft.Visible = true;                                        
                } else if (_guessNumber == 3) {
                    pbStandRight.Visible = true;
                } else if (_guessNumber == 4) {
                    pbDiagonal.Visible = true;
                } else if (_guessNumber == 5) {
                    pbTop.Visible = true;
                } else if (_guessNumber == 6) {
                    pbNoose.Visible = true;
                    pbNoose.BringToFront();
                } else if (_guessNumber == 7) {
                    pbHead.Visible = true;
                } else if (_guessNumber == 8) {
                    pbBody.Visible = true;
                    pbBody.BringToFront();
                } else if (_guessNumber == 9) {
                    pbLeftArm.Visible = true;
                    pbLeftArm.BringToFront();
                    pbBody.BringToFront();
                } else if (_guessNumber == 10) {
                    pbRightArm.Visible = true;
                    pbRightArm.BringToFront();
                } else if (_guessNumber == 11) {
                    pbLeftLeg.Visible = true;
                    pbLeftLeg.BringToFront();
                } else if (_guessNumber == 12) {
                    pbRightLeg.Visible = true;
                    pbRightLeg.BringToFront();
                }
            }
        }

        /// <summary>
        /// Builds the Hangman for a 10 letter word
        /// </summary>
        private void Hangman10Letters() {
            if (_lengthOfWord == 10) {
                if (_guessNumber == 1) {
                    pbVertical.Visible = true;
                    pbVertical.BringToFront();
                    pbStandMiddle.BringToFront();
                    pbStandRight.BringToFront();
                } else if (_guessNumber == 2) {
                    pbStandMiddle.Visible = true;
                } else if (_guessNumber == 3) { 
                    pbStandLeft.Visible = true;
                } else if (_guessNumber == 4) {
                    pbStandRight.Visible = true;
                } else if (_guessNumber == 5) {
                    pbDiagonal.Visible = true;
                } else if (_guessNumber == 6) {
                    pbTop.Visible = true;
                } else if (_guessNumber == 7) {
                    pbNoose.Visible = true;
                    pbNoose.BringToFront();
                } else if (_guessNumber == 8) {
                    pbHead.Visible = true;
                } else if (_guessNumber == 9) {
                    pbBody.Visible = true;
                    pbBody.BringToFront();
                } else if (_guessNumber == 10) {
                    pbLeftArm.Visible = true;
                    pbLeftArm.BringToFront();
                    pbBody.BringToFront();
                } else if (_guessNumber == 11) {
                    pbRightArm.Visible = true;
                    pbRightArm.BringToFront();
                } else if (_guessNumber == 12) {
                    pbLeftLeg.Visible = true;
                    pbLeftLeg.BringToFront();
                } else if (_guessNumber == 13) {
                    pbRightLeg.Visible = true;
                    pbRightLeg.BringToFront();
                }
            }
        }

    }
}
