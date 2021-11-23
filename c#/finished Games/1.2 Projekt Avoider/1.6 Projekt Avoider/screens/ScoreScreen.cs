﻿using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using _1._6_Projekt_Avoider.entities;
using _1._6_Projekt_Avoider.framework;
using _1._6_Projekt_Avoider.utility;
using _1._6_Projekt_Avoider.screens;

namespace _1._6_Projekt_Avoider.screens
{
    class ScoreScreen : Screen
    {

        public ScoreScreen(int _score)
        {
            score = _score;
        }

        Font font;
        Text text;
        Text ScoreText;
        Text text2;
        int score;

        public override void setup()
        {
            font = new Font("assets/arial.ttf");
            text = new Text("Winner", font, 100);
            text.Origin = new Vector2f(text.GetLocalBounds().Width / 2, text.GetLocalBounds().Height / 2);
            text.Position = new Vector2f(375, 100);

            ScoreText = new Text("Fails: " + score.ToString(), font, 50);
            ScoreText.Origin = new Vector2f(ScoreText.GetLocalBounds().Width / 2, ScoreText.GetLocalBounds().Height / 2);
            ScoreText.Position = new Vector2f(375, 270);

            text2 = new Text("Press Enter to restart", font, 20);
            text2.Origin = new Vector2f(text2.GetLocalBounds().Width / 2, text2.GetLocalBounds().Height / 2);
            text2.Position = new Vector2f(375, 220);

        }

        public override void loop()
        {

            if (Keyboard.IsKeyPressed(Keyboard.Key.Return))
            {
                game.switchScreen(new MainScreen());
            }
        }

        public override void render()
        {
            draw(text);
            draw(text2);
            draw(ScoreText);
        }
    }
}