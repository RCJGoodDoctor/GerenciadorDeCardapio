import { Proteina } from "../Domain/Entities/Proteina";
import { IProteinaRepository } from "./interfaces/IProteinaRepository";
import { prisma } from "./prisma";
export class ProteinaPrismaRepository implements IProteinaRepository{
    async getProteinaById(id: number):Promise<Proteina | null> {
        const data = await prisma.proteina.findUnique({
            where: {
                cd_proteina: id
            }
            
        });
        const proteina = data == null? data : new Proteina(data.cd_proteina,data.nm_proteina)
        return proteina
    }
    async getAllProteina():Promise<Proteina[]> {
        const data = await prisma.proteina.findMany()
        return  data.map(data => new Proteina(data.cd_proteina,data.nm_proteina))
    }

}