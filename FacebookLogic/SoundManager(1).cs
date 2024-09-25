using System;
using System.IO;
using System.Media;
using System.Threading;

namespace FacebookLogic
{
    public class SoundManager
    {
        private string m_SoundDirectory;
        private SoundPlayer m_Player;

        public SoundManager(string i_userName)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            m_SoundDirectory = Path.Combine(projectDirectory, "Sound", i_userName);

            if (!Directory.Exists(m_SoundDirectory))
            {
                Directory.CreateDirectory(m_SoundDirectory);
            }

            m_Player = new SoundPlayer();
            string soundFilePath = getSoundFile();

            if (!string.IsNullOrEmpty(soundFilePath))
            {
                m_Player.SoundLocation = soundFilePath;
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
