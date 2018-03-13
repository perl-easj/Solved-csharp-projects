﻿using System;
using System.Collections.Generic;
using CryptoCrownLib;

namespace CryptoCrowns
{
    public class MinerSequential : MinerBase
    {
        public MinerSequential(string owner) : base(owner)
        {
        }

        public override void MineSingleCryptoCrown()
        {
            bool foundCrown = false;
            for (int key = 0; (key <= CurrentMaxKey) && !foundCrown; key++)
            {
                foundCrown = AttemptToMineSingleCryptoCrown(key);
            }
        }
    }
}