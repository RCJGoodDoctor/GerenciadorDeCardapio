import { Proteina } from "../../Domain/Entities/Proteina";

export interface IProteinaRepository{
    getProteinaById(cd_proteina:number):Promise<Proteina | null>
    getAllProteina(): Promise<Proteina[]>
}