﻿using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using Enteties_3.entities;
using Enteties_3.framework;
using Enteties_3.utility;
using Enteties_3.screens;

namespace Enteties_3.framework
{
    class Start
    {
        static void Main()
        {
            Game game = new Game();

            game.startGame();
        }

    }
}
