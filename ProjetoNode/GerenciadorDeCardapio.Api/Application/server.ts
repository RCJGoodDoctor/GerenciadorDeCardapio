import fastify from "fastify";
import { ProteinaController} from "./ProteinaController";
import { ProteinaPrismaRepository } from "../Infra/ProteinaPrismaRepository";
const app = fastify()
const proteinaRepository = new ProteinaPrismaRepository()
const proteinaController = new ProteinaController(proteinaRepository)
app.register(proteinaController.getProteina)
app.listen({port:8000}).then(() =>{
	console.log("Server is gone")
})

