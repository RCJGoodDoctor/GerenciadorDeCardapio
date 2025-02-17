import { Prato } from "./Prato";
export class Cardapio {
    private dt_cardapio: Date;
    private prato: Prato;
  
    constructor(dt_cardapio: Date, prato: Prato) {
      this.dt_cardapio = dt_cardapio;
      this.prato = prato;
    }
  
    getDtCardapio(): Date {
      return this.dt_cardapio;
    }
  
    getPrato(): Prato {
      return this.prato;
    }
  
    setDtCardapio(dt_cardapio: Date): void {
      this.dt_cardapio = dt_cardapio;
    }
  }