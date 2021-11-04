using System;

namespace Zoo
{
    enum livingState {
        Alive,
        Dead
    }
    enum healthState {
        Good,
        Sick
    }

    // Base class
    abstract class Animal
    {
        private livingState livingState;
        private healthState healthState;
        private int age;
        private bool hungry;
        protected string voice;

        public Animal (livingState livingState = livingState.Alive, healthState healthState = healthState.Good, int age = 0, bool hungry = false) {
            this.livingState = livingState;
            this.healthState = healthState;
            this.age = age;
            this.hungry = hungry;
        }

        public bool isAlive() {
            if (this.livingState == livingState.Alive) {
                return true;
            } else {
                return false;
            }
        }
        public bool isHealthy() {
            if (this.healthState == healthState.Good) {
                return true;
            } else {
                return false;
            }
        }
        public int getAge() {
            return this.age;
        }
        public bool isHungry() {
            return this.hungry;
        }
    }
}