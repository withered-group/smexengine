using System;

namespace SmexEngine {
  class MainProgram {

    // CHANGE WHEN NOT IN DEV ENV
    bool dev = true;

    static void Init() {
      Console.WriteLine(value: "[SMEX] Attempting to start...");
      // Do startup actions
      // Keyboard, graphics, etc
    }

    static void Main(string[] args) {
      Init();
    }
  }
}