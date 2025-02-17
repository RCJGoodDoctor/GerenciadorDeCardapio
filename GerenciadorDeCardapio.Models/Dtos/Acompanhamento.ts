export class AcompanhamentoDTO {
    cd_acompanhamento: number;
    nm_acompanhamento: string;
  
    constructor(cd_acompanhamento: number, nm_acompanhamento: string) {
      this.cd_acompanhamento = cd_acompanhamento;
      this.nm_acompanhamento = nm_acompanhamento;
    }
  }