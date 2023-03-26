
using System.Security.Cryptography.X509Certificates;

int int1 = 5_000_000; // -2,147,483,648 to 2,147,483,648 (4 bytes of memory)
uint uint1 = 3_147_483_647; // 0 to 4,294,967,295 (4 bytes of memory)

byte byte1 = 130; // 0 - 255 ( 1 byte of memory)
sbyte sbyte2 = -100; // -128 to 127  ( 1 byte of memory)

short short1 = 25_000; // -32768 to 32767 (2 bytes of memory)
ushort ushort1 = 60_000; // 0 to 65,535 (2 bytes of memory)

long long1 = 300_147_483_647; // (8 bytes of memory)
ulong ulong1 = 545_300_147_483_647; // (8 bytes of memory)

float height = 180.12F; // Occupies 4 bites; precision of 6 to 9 digits
double width = 4.12; // Occupies 8 bites; precision of 15 to 17 digits
decimal amount = 9.99m; // Occupies 16 bites; precision of 28 to 29 digits

bool valid = true;

char letter = 'A';
string letters = "abcde";

string longTest = "This is a sentence, \"very cool!\". I know";
string longTest2 = "we use \\ to start a scape sequence";

string carta = @"To whom it may concern,

Dear client, you own me money. The bank says: ""pay us""

Att. The Administration
";

string filePath = "c:\\MyDocuments\\MyFolder\\MyFile.txt";
string filePath2 = @"c:\MyDocuments\MyFolder\MyFile.txt";

string myFirstRSL = $"""
                    Hello, "nice" to meet 'you', I am Ulises - {height},
                    I like to program.
                    """;
Console.WriteLine(myFirstRSL);