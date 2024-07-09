/*
LEETCODE CHALLENGE: Longest Palindromic Substring
LINK: https://leetcode.com/problems/longest-palindromic-substring
Given a string s, return the longest palindromic substring in s. 

Example 1:
Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.

Example 2:
Input: s = "cbbd"
Output: "bb"
*/

/*
string ReverseString(string ogStr)
{
    string revStr = "";
    for (int i = ogStr.Length-1; i >= 0; i-- )
    {
        revStr += ogStr[i];
    }
    return revStr;
}
*/

string ReverseString(string ogStr)
{
    char[] strCharArr = ogStr.ToCharArray();
    Array.Reverse(strCharArr);
    return new string(strCharArr);
}

string LongestPalindrome(string s)
{
    string longestPalin = "";
    for (int i = 0; i < s.Length; i++)
    {
        string strBit = s.Substring(i, s.Length-i);
        while (strBit.Length > 0)
        {
            if (strBit == ReverseString(strBit) && 
                (strBit.Length > longestPalin.Length))
            {
                longestPalin = strBit;
            }
            strBit = strBit.Substring(0, strBit.Length - 1);
        }
    }
    return longestPalin;
}

string targetStr = "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";
Console.WriteLine(LongestPalindrome(targetStr));
