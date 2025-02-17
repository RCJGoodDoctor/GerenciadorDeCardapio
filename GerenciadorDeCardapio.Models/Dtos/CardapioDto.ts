export class CardapioDTO {
    dt_cardapio: Date;
    cd_prato: number;
  
    constructor(dt_cardapio: Date, cd_prato: number) {
      this.dt_cardapio = dt_cardapio;
      this.cd_prato = cd_prato;
    }
  }