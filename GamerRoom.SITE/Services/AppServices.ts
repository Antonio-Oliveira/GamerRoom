import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { enviroment } from "src/Enviroments/enviroment";
import { Game } from "..Models/Game";
import { token } from "../Models/Game";
Injectable({providedIn: 'root'})

export class Service
{
    private readonly urlBackEnd = enviroment["apiBackEnd"];
    private readonly urlToken = enviroment["apiToken"];
    tokenUsuario: any;
    constructor(private httpClient: HttpClient){

    }

    public GerarToken(){
        var url = this.urlToken;
        var usuario = {
            Email: "alguem@alguem.com",
            Password: "@alguem222"
        }
        return this.tokenUsuario = this.httpClient.post<string>
        (url, usuario, {
            headers: new HttpHeaders({
                'Content-Type': 'application/json',
                'Access-Control-Allow-Origin': '*',
                'Acess-Control-Allow-Methods': 'GET, POST, OPTIONS, PUT, PATCH, DELETE',
                'Acess-Control-Allow-Headers':
                'Acess-Control-Allow-Header, Origins,Accept, X-Requested-With, Content-Type, Acess-Control-Request'
            })
        })
    }

    public ListarGame(tokenUsuario: any)
    {
        var url = this.urlBackEnd + ""
    }
}