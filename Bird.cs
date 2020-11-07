using System;

namespace lesson15
{
    class Bird : Animal
    {
        private readonly Walking walking;
        private readonly Fly fly;

        public Bird(Walking walking, Fly fly)
        {
            this.walking = walking;
            this.fly = fly;
        }
        // composition
        public void walk()
        {
            walking.walking();
        }

        public void flying()
        {
            fly.Flying();
        }

    }
}
