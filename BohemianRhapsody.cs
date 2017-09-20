using System;

namespace queen
{
    // Is this the real life?
    // Is this just fantasy?
    // Caught in a landslide,
    // No escape from reality
    // Open your eyes,
    // Look up to the skies and see,
    // I'm just a poor boy, I need no sympathy,
    // Because I'm easy come, easy go
    // Little high, little low
    // Any way the wind blows doesn't really matter to me, to me
    class BohemianRhapsody
    {
        public BohemianRhapsody()
        {
            try
            {
                Assert(Life.Real);
                Assert(Life.Fantasy);
            }
            catch (LandSlideException)
            {
                Console.WriteLine("No escape from reality");
                #region Reality
                while (true)
                {
                    character.Eyes.ForEach(eye =>
                        eye.Open().Orient(Direction.Sky).See()
                    );
                    self.Wealth = null;
                    self.Sex = Sex.Male;

                    self.Sympathies.Clear();

                    if (self.ComeDifficulty == Difficulty.Easy &&
                        self.GoDifficulty == Difficulty.Easy &&
                        self.High < 0.1 &&
                        self.Low < 0.1)
                    {
                        switch (wind.Direction)
                        {
                            case Direction.North:
                            case Direction.East:
                            case Direction.South:
                            case Direction.West:
                            default:
                                self.Matter = false;
                                piano.Play();
                                break;
                        }
                    }
                }
                #endregion
            }
        }

        private static void Assert(Life? life)
        {
            if (life == Life.Real)
            {
                System.Console.WriteLine("Is this the real life?");
            }
            if (life == Life.Fantasy)
            {
                System.Console.WriteLine("Is this just fantasy?");
                throw new LandSlideException();
            }
        }

        private Self self = new Self();
        private Character character = new Character();
        private Wind wind = new Wind();
        private Piano piano = new Piano();
    }
}
