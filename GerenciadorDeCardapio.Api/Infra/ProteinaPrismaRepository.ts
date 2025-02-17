import { Proteina } from "../Domain/Entities/Proteina";
import { IProteinaRepository } from "./interfaces/IProteinaRepository";
import { prisma } from "./prisma";
export class ProteinaPrismaRepository implements IProteinaRepository{
    getProteinaById(id: number): Proteina {
        return prisma.Proteina.findUnique({
                where: {
                    cd_proteina: id
                }

        });
    }
    getAllProteina(): [Proteina] {
        return prisma.Proteina.findMany()
    }

}