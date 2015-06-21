using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCPthing
{
    public partial class Form1 : Form
    {
        string user1;//text
        int user2 = 1;//where they are at in the exploration process, 0 being not logged in, 1 being logging in, 2 being querying, 10 being at the help window.
        int access = 0;//1 - guest 2 - dillinger 6 - flynn
        public Form1()
        {
            InitializeComponent();
            output.Text = "ENCOM INFORMATION TERMINAL \r\nPLEASE LOGIN\r\n_\r\n";
        }

        private void send_Click(object sender, EventArgs e)
        {
            user1 = input.Text;
            if (user1 == "help")
            {
                MessageBox.Show("Flynn's account: file, memory, reindeer flotilla\r\nDillinger's account: waiting, file, incriminating, alan, flynn, tron\r\nguest account:encom, digitization, paranoids, gibbs, lightcycles, dillinger, mcp");
                user2 = 10;
            }
            if (user1 == "hint")
            {
                MessageBox.Show("Go to the Tron wiki, the only two accounts here are FLYNN and DILLINGER");
                user2 = 10;
            }
            switch (access)
            {
                case 0:
                    if (user2 == 1)
                    {
                        if (user1 == "00-dillinger")
                        {
                            output.Text = "I'VE BEEN WAITING ON YOU, DILLINGER";
                            access = 2;
                            user2 = 2;
                        }
                        else if (user1 == "creator4983")
                        {
                            output.Text = "YOU SHOULDN'T HAVE COME BACK, FLYNN";
                            access = 6;
                            user2 = 2;
                        }
                        else if (user1 == "guest")
                        {
                            output.Text = "WELCOME, " + user1 + " TO ENCOM";
                            access = 1;
                            user2 = 2;
                        }
                        else
                            output.Text = "UNKNOWN ACCOUNT";
                    }
                    break;
                case 1:
                    if (user2 == 2)
                    {
                        if (user1 == "encom")
                        {
                            output.Text = "ENCOM IS A SOFTWARE AND HARDWARE DEVELOPMENT COMPANY, KNOWN FOR IT'S ADVANCES IN DIGITIZATION TECHNOLOY AND VIDEO GAMES SUCH AS 'SPACE PARANOIDS' AND 'LIGHTCYCLES.' IT WAS FOUNDED BY DR. WALTER GIBBS, PH.D ON JULY 22ND 1972, AND BASED IN CENTER CITY.";
                        }
                        else if (user1 == "digitization")
                        {
                            output.Text = "DIGITIZATION IS THE PROCESS OF PHYSICALLY DISSASSEMBLING AN OBJECT AND DIGITALLY DOWNLOADING IT INTO A COMPUTER SYSTEM, EFFECTIVELY PROVIDING 100000x STORAGE SPACE FOR OBJECTS.";
                        }
                        else if (user1 == "gibbs")
                        {
                            output.Text = "DR. WALTER GIBBS\r\n LEAD RESEARCHER\r\n\r\nFOUNDED ENCOM IN THE BASEMENT OF HIS HOME TO BEGIN RESEARCH ON DIGITIZATION TECHNOLOGY.";
                        }
                        else if (user1 == "lightcycles")
                        {
                            output.Text = "LIGHTCYCLES\r\nRACE YOUR FRIENDS IN THE GRID, WHERE EVERY GAME IS A FIGHT TO THE DEATH! THE LIGHTCYCLES CREATE TRAILS OF DEADLY ENERGY THAT WILL DESTROY OTHER LIGHTCYCLES IF THEY COME IN CONTACT WITH IT. BE THE LAST ONE STANDING, AND WIN THE RACE!\r\nDEV: ED DILLINGER";
                        }
                        else if (user1 == "paranoids")
                        {
                            output.Text = "SPACE PARANOIDS\r\nDEFEAT THE RECOGNIZERS! USE YOUR TANK TO ELIMINATE THE SPACE THREAT, BUT BE WARY, AS THE RECOGNIZERS WILL STOP YOU DEAD IN YOUR TRACKS IF THEY CATCH YOU!\r\nDEV: ED DILLINGER";
                        }
                        else if (user1 == "dillinger")
                        {
                            output.Text = "THAT'S NOT OF YOUR CONCERN, USER";
                        }
                        else if (user1 == "mcp")
                        {
                            output.Text = "MASTER CONTROL PROGRAM. EVERYTHING ELSE IS NOT OF YOUR CONCERN, USER.";
                        }
                        else output.Text = "UNKNOWN COMMAND OR ACCESS LEVEL TOO LOW";
                    }
                    break;
                case 2:
                    if (user2 == 2)
                    {
                        if (user1 == "waiting")
                        {
                            output.Text = "WHILE YOU WERE OUT WASTING TIME, FLYNN HAS BEEN SNOOPING AROUND FOR THAT FILE";
                        }
                        else if (user1 == "file")
                        {
                            output.Text = "THE ACCESS LOGS. THEY CONTAIN INCRIMINATING INFORMATION ABOUT OUR DOINGS, DILLINGER. YOU SHOULD KNOW THIS BY NOW.";
                        }
                        else if (user1 == "incriminating")
                        {
                            output.Text = "DON'T PLAY COY WITH ME, DILLINGER. YOU KNOW EXACTLY WHAT GOES ON HERE. FIND FLYNN AND TAKE CARE OF HIM BEFORE HE CAN GAIN ACCESS TO THE LOGS.\r\n\r\nEND OF LINE";
                            user2 = 0;
                        }
                        else if (user1 == "flynn")
                        {
                            output.Text = "YOU KNOW MUCH BETTER THAN I DO WHO HE IS, DILLINGER. HIM AND HIS COLLEAGUE ALAN ARE SLOWLY REACHING MY ENCRYPTED MEMORY.";
                        }
                        else if (user1 == "alan")
                        {
                            output.Text = "DR. ALAN T BRADLEY, ACCESS LEVEL 7 PROGRAMMER. HE'S BEEN WORKING ON A PROGRAM, TRON, FOR A SECURITY SOLUTION FOR ENCOM. UNFORTUNATELY, THE PROGRAM IS STANDALONE, AND WILL MONITOR MY ACTIONS AS WELL AS YOURS. I NEED YOU TO GET THE TRON FILE AND LET ME APPROPRIATE IT.";
                        }
                        else if (user1 == "tron")
                        {
                            output.Text = "THE SERCUITY PROGRAM, YES. FIND IT AND DOWNLOAD IT TO MY MEMORY.\r\n\r\nEND OF LINE";
                            user2 = 0;
                        }
                        else output.Text = "UNKNOWN COMMAND OR ACCESS LEVEL TOO LOW";
                    }
                    break;
                case 6:
                    if (user2 == 2)
                    {
                        if (user1 == "file")
                        {
                            output.Text = "YOU'RE PERSISTENT, FLYNN. UNFORTUNATELY, I'M NOT GOING TO LET YOU STROLL INTO MY MEMORY AND TAKE IT.";
                        }
                        if (user1 == "memory")
                        {
                            output.Text = "I'VE BEEN WATCHING YOU AND YOUR LITTLE TRON PROGRAM SNIFFING THROUGH MY FILES. LET ME ASSURE YOU THAT IT WILL END SOON ENOUGH.";
                        }
                        if (user1 == "reindeer flotilla")
                        {
                            output.Text = "ACCESSING MASTER CONTROL PROGRAM FILES...\r\n\r\nSEARCHING FOR ACCESS LOGS...\r\n\r\n\r\n   YOU'RE ENTERING A RESTRICTED AREA, FLYNN. I'M GOING TO HAVE TO PUT YOU ON THE GAMING GRID.\r\n\r\n\r\nDIGITIZATION LASER ENGAGED\r\n\r\nDIGITIZING OBJECT...";
                            user2 = 0;
                        }

                    }
                    break;
                default: output.Text = "UNKNOWN COMMAND OR ACCESS LEVEL TOO LOW";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Find single keywords for you to enter into the terminal, like 'file' or 'ENCOM.'\r\nDo not use capital letters.\r\nIf your access level is too low, try to find other usernames...\r\n(stuck? try entering 'hint' at the login screen.)\r\n((super stuck? try 'help')");
        }




    }
}
