using System;

namespace lab08
{
    internal class User
    {
        public string Name { get; set; }

        public int Version { get; set; }

        public User(string name, int version) 
        { 
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            if (version == default(int))
            {
                throw new ArgumentNullException("version");
            }

            Name = name;
            Version = version;
        }

        public delegate void UpgradeHandler(string version);
        
        public delegate void WorkHandler(string typeWork);

        public event UpgradeHandler Upgrade;

        public event WorkHandler Work;

        public void DoUpgrade(int version)
        {
            if (version <= Version)
            {
                throw new ArgumentException("Обновление невозможно: переданная версия старше текущей");
            }

            Version = version;
            Upgrade?.Invoke($"Пользователь {Name} обновлён до версии {Version}");
        }

        public void DoWork(string typeWork)
        {
            Work?.Invoke($"Пользователь {Name} выполняет работу {typeWork}");
        }
    }
}
