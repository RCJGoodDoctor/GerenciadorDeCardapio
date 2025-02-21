export class Salada {
    private cd_salada: number;
    private nm_salada: string;
  
    constructor(cd_salada: number, nm_salada: string) {
      this.cd_salada = cd_salada;
      this.nm_salada = nm_salada;
    }
  
    getCdSalada(): number {
      return this.cd_salada;
    }
  
    getNmSalada(): string {
      return this.nm_salada;
    }
  
    setNmSalada(nm_salada: string): void {
      this.nm_salada = nm_salada;
    }
  }