﻿using System.Diagnostics;

namespace BoxKite.Twitter.Console.Helpers
{
    public class GetUnlockCodeFromTwitter : IGetUnlockCodeFromTwitter
    {
        public void DisplayAuthInBrowser(string u)
        {
            Process.Start(u);
        }
    }
}
