import { ISaladaRepository } from "./interfaces/ISaladaRepository";
import { Salada } from "../Domain/Entities/Salada";
import { prisma } from "./prisma";
export class SaladaPrismaRepository implements ISaladaRepository{
    getProteinaById(id: number): any {
        return prisma.salada.findUnique({
            where: {
                cd_salada: id
            }

    });
    }
    getAllProteina(): any {
        return prisma.salada.findMany()
    }

}