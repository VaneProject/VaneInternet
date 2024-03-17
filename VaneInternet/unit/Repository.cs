using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using IWshRuntimeLibrary;

namespace VaneInternet.unit {
    public static class Repository {
        private const string Project = "Vane";
        private const string Name = "Internet";
        private const string SaveFile = "SaveFile";
        private const string Ext = ".vane";

        private static readonly Environment.SpecialFolder ProgramFilesId = Environment.Is64BitOperatingSystem 
            ? Environment.SpecialFolder.ProgramFiles
            : Environment.SpecialFolder.ProgramFilesX86;

        /**
         * 프로젝트 데이터 저장하는 파일 위치
         */
        public static string GetProgramsPath() => 
            Path.Combine(Environment.GetFolderPath(ProgramFilesId), Project, Name, SaveFile);

        /**
         * 저장된 파일 데이터 로드
         */
        public static Dictionary<string, Internet> GetListFileList() {
            var directoryInfo = new DirectoryInfo(GetProgramsPath());
            if (!directoryInfo.Exists) {
                directoryInfo.Create();
            }

            var pair = new Dictionary<string, Internet>();
            foreach (var file in directoryInfo.GetFiles("*" + Ext)) {
                var name = file.Name;
                name = name.Substring(0, name.LastIndexOf('.'));
                pair.Add(name, GetInternet(file.FullName));
            }
            return pair;
        }
        
        /**
         * 바로가기 파일 생성
         * fileName : 파일 이름
         * option : 실행 옵션
         */
        public static void CreateShortcut(string fileName, string option) {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var shortcutPath = Path.Combine(desktopPath, fileName + ".lnk");
            var targetPath = System.Windows.Forms.Application.ExecutablePath;

            WshShell shell = new WshShellClass();
            var shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
            shortcut.Description = "Vane Project Internet Shortcut file";
            shortcut.IconLocation = targetPath;
            shortcut.TargetPath = targetPath + " \"" + option + "\"";
            shortcut.Save();
        }

        /**
         * 파일 가져오는 함수
         */
        private static Internet GetInternet(string filePath) {
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read)) {
                return (Internet)formatter.Deserialize(stream);
            }
        }

        private static void SaveInternet(string filePath, Internet internet) {
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write)) {
                formatter.Serialize(stream, internet);
            }
        }
    }
}