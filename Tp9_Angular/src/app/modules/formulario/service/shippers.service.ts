import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Shippers } from '../shippers';

@Injectable({
  providedIn: 'root'
})
export class ShipersService {

  Url:string = `${environment.url}shippers`;

  constructor(private readonly http: HttpClient) { }

  public getShippers(): Observable<Array<Shippers>>{
    return this.http.get<Array<Shippers>>(this.Url);
  }
  
  public getShippersId(id:number): Observable <Shippers>{
    return this.http.get<Shippers>(`${this.Url}/${id}`);
  }

  public postShippers(Shippers:Shippers): Observable <any>{
    return this.http.post(this.Url, Shippers);
  } 

  public updateShippers(id:number, Shippers:Shippers): Observable <any>{
    return this.http.put(`${this.Url}/${id}`, Shippers);
  }

  public deleteShippers(id:number): Observable <any>{
    return this.http.delete(`${this.Url}/${id}`);
  }

}
