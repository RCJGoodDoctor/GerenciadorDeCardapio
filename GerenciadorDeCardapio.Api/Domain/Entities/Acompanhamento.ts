export class Acompanhamento {
    private cd_acompanhamento: number;
    private nm_acompanhamento: string;
  
    constructor(cd_acompanhamento: number, nm_acompanhamento: string) {
      this.cd_acompanhamento = cd_acompanhamento;
      this.nm_acompanhamento = nm_acompanhamento;
    }
  
    getCdAcompanhamento(): number {
      return this.cd_acompanhamento;
    }
  
    getNmAcompanhamento(): string {
      return this.nm_acompanhamento;
    }
  
    setNmAcompanhamento(nm_acompanhamento: string): void {
      this.nm_acompanhamento = nm_acompanhamento;
    }
  }