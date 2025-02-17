export class PratoDTO {
    cd_prato: number;
    cd_proteina: number;
    nm_detalhe: string;
    cd_acompanhamento: number;
    cd_salada: number;
  
    constructor(
      cd_prato: number,
      cd_proteina: number,
      nm_detalhe: string,
      cd_acompanhamento: number,
      cd_salada: number
    ) {
      this.cd_prato = cd_prato;
      this.cd_proteina = cd_proteina;
      this.nm_detalhe = nm_detalhe;
      this.cd_acompanhamento = cd_acompanhamento;
      this.cd_salada = cd_salada;
    }
  }