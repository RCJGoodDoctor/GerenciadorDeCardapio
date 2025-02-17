export class ProteinaDTO {
    cd_proteina: number;
    nm_proteina: string;
  
    constructor(cd_proteina: number, nm_proteina: string) {
      this.cd_proteina = cd_proteina;
      this.nm_proteina = nm_proteina;
    }
  }