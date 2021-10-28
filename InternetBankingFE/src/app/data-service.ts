import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http"

interface ITransaction {
    getTransactionList$: () => Observable<any>
    getTransactionDetails$: (id: number) => Observable<any>
}

@Injectable({providedIn: "root"})
export class ResourceDataService implements ITransaction{
    constructor(private httpClient: HttpClient){}
    getTransactionList$(){
        return this.httpClient.get("api/transaction")
    };
    getTransactionDetails$(id: number){
        return this.httpClient.get(`api/transaction/${id}`)
    };
}