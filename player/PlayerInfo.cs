using System;

namespace bashMUD.Player {
  struct Statistics {
    // Combat statistics -- directly affect raw numerical interactions
    private int hp, offense, defense;
    
    // Script statistics -- affect capabilities and flexibility of scripts
    private int cpu, ram, storage;
  }

  class Player { }
}