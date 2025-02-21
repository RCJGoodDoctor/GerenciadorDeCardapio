import { Salada } from "../../Domain/Entities/Salada"

export interface ISaladaRepository{
    
    getProteinaById(cd_proteina:number):Salada
    getAllProteina():[Salada]
    
}