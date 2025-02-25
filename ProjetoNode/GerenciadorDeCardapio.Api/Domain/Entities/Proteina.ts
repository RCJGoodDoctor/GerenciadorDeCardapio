export class Proteina {
    private cd_proteina: number ;
    private nm_proteina: string|null;
  
    constructor(cd_proteina: number, nm_proteina: string | null) {
      this.cd_proteina = cd_proteina;
      this.nm_proteina = nm_proteina;
    }
  
    getCdProteina(): number {
      return this.cd_proteina;
    }
  
    getNmProteina(): string | null {
      return this.nm_proteina;
    }
  
    setNmProteina(nm_proteina: string): void {
      this.nm_proteina = nm_proteina;
    }
  }