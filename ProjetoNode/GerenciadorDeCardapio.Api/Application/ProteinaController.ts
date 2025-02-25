import { FastifyInstance } from "fastify";
import { z } from 'zod';
import { ProteinaPrismaRepository } from "../Infra/ProteinaPrismaRepository";
import { request } from "http";
import { IProteinaRepository } from "../Infra/interfaces/IProteinaRepository";
export class ProteinaController{
    private repository:IProteinaRepository
    constructor(repository: IProteinaRepository) {
          this.repository = repository;
          
        }
        getProteina = async (app: FastifyInstance) => {
            app.get('/proteina', async (request, reply) => {
                // Adicionar await para garantir que a Promise seja resolvida
                const proteins = await this.repository.getAllProteina();
                return reply.status(200).send(proteins);
            });
            app.get('/proteina/:id', async (request, reply) => {
                // Adicionar await para garantir que a Promise seja resolvida
                const params = z.object({
                    id: z.string()
                })
                const {id} = params.parse(request.params)
                const protein = await this.repository.getProteinaById(Number(id));
                return reply.status(200).send(protein);
            });
        };
}