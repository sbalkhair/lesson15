using System;

namespace lesson15
{
    class Fly
    {

    }
    class Bird : Animal
    {
        private readonly Walking walking;

        public Bird(Walking walking)
        {
            this.walking = walking;
        }

        public void walk()
        {
            walking.walking();
        }

    }
}
