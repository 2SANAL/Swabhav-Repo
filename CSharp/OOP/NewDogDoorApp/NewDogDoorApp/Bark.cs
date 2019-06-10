using System;


namespace NewDogDoorApp
{
    class Bark
    {
        private string _sound;

        public Bark(string sound)
        {
            this._sound = sound;
        }
        public string GetSound()
        {
            return _sound;
        }
        public bool Equal(Object bark)
        {
            if (bark is Bark)
            {
                Bark otherBark = (Bark)bark;
                return SoundCheck(otherBark);
            }
            return false;
        }
        public bool SoundCheck(Bark otherBarks)
        {
            if (_sound.Equals(otherBarks._sound))

                return true;

            return false;
        }
    }
}
