using System;

namespace SmexEngine {
  class MainProgram {

    // CHANGE WHEN NOT IN DEV ENV
    static bool dev = false;

    static void Init() {
      if (dev) Console.WriteLine(value: "[SMEX] Attempting to start in development state...");
      else Console.WriteLine(value: "[SMEX] Attempting to start...");
      // Do startup actions
      // Keyboard, graphics, etc
    }

    static void Main(string[] args) {
      if (!(args.Count() == 0)) {
        if (Array.IndexOf(args, "--dev") > -1) {
          dev = true;
        }
      }
      Init();
    }
  }
}