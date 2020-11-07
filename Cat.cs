using System;

namespace lesson15
{
    class Cat : Animal
    {
        private readonly Walking walking;

        public Cat(Walking walking)
        {
            this.walking = walking;
        }

        public void walk()
        {
            walking.walking();
        }

    }
}
