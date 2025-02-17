import { Proteina } from "./Proteina";
import { Acompanhamento } from "./Acompanhamento";
import { Salada } from "./Salada";
export class Prato {
    private cd_prato: number;
    private proteina: Proteina;
    private nm_detalhe: string;
    private acompanhamento: Acompanhamento;
    private salada: Salada;
  
    constructor(
      cd_prato: number,
      proteina: Proteina,
      nm_detalhe: string,
      acompanhamento: Acompanhamento,
      salada: Salada
    ) {
      this.cd_prato = cd_prato;
      this.proteina = proteina;
      this.nm_detalhe = nm_detalhe;
      this.acompanhamento = acompanhamento;
      this.salada = salada;
    }
  
    getCdPrato(): number {
      return this.cd_prato;
    }
  
    getProteina(): Proteina {
      return this.proteina;
    }
  
    getNmDetalhe(): string {
      return this.nm_detalhe;
    }
  
    getAcompanhamento(): Acompanhamento {
      return this.acompanhamento;
    }
  
    getSalada(): Salada {
      return this.salada;
    }
  
    setNmDetalhe(nm_detalhe: string): void {
      this.nm_detalhe = nm_detalhe;
    }
  }