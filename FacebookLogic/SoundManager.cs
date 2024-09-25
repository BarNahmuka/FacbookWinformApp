using System;
using System.IO;
using System.Media;

namespace FacebookLogic
{
    public class SoundManager
    {
        private static SoundManager s_Instance = null;
        private static readonly object s_LockObj = new object();
        private string m_SoundDirectory;
        private SoundPlayer m_Player;
        private string m_CurrentUserName;
        private string m_PreviousUserName;

        private SoundManager()
        {
            m_Player = new SoundPlayer();
        }

        public static SoundManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new SoundManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public void Initialize(string i_UserName)
        {
            m_PreviousUserName = null;
            setUser(i_UserName);
        }

        private void setUser(string i_UserName)
        {
            m_CurrentUserName = i_UserName;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            m_SoundDirectory = Path.Combine(projectDirectory, "Sound", i_UserName);

            if (!Directory.Exists(m_SoundDirectory))
            {
                Directory.CreateDirectory(m_SoundDirectory);
            }

            string soundFilePath = getSoundFile();

            if (!string.IsNullOrEmpty(soundFilePath))
            {
                m_Player.SoundLocation = soundFilePath;
            }
        }

        public void SwitchUser(string i_UserName)
        {
            m_PreviousUserName = m_CurrentUserName;
            setUser(i_UserName);
        }

        public void RevertToPreviousUser()
        {
            if (!string.IsNullOrEmpty(m_PreviousUserName))
            {
                setUser(m_PreviousUserName);
                m_PreviousUserName = null;
            }
        }

        public void SetSoundFile(string soundFile)
        {
            removeExistingFiles();
            string newSoundFilePath = Path.Combine(m_SoundDirectory, Path.GetFileName(soundFile));
            File.Copy(soundFile, newSoundFilePath, true);
            m_Player.SoundLocation = newSoundFilePath;
            m_Player.Load();
        }

        public void PlaySound()
        {
            if (!string.IsNullOrEmpty(m_Player.SoundLocation))
            {
                m_Player.Play();
            }
            else
            {
                throw new FileNotFoundException("Sound file not found.");
            }
        }

        public void StopSound()
        {
            m_Player.Stop();
        }

        public void RemoveSound()
        {
            removeExistingFiles();
            m_Player.SoundLocation = null;
        }

        public bool CanPlaySound()
        {
            return !string.IsNullOrEmpty(m_Player.SoundLocation);
        }

        private string getSoundFile()
        {
            var files = Directory.GetFiles(m_SoundDirectory);
            return files.Length == 1 ? files[0] : null;
        }

        private void removeExistingFiles()
        {
            var files = Directory.GetFiles(m_SoundDirectory);

            foreach (var file in files)
            {
                File.Delete(file);
            }
        }
    }
}
