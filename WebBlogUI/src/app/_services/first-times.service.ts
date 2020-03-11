import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment'
import { HttpClient} from '@angular/common/http'
import { Member } from '../_models/Member'

@Injectable({
  providedIn: 'root'
})
export class FirstTimesService {
  private BaseUrl = environment.baseUrl + '/api/firsttimes';

  constructor(private http : HttpClient) { }

  //method
  insertDataAll(member : Member){
    console.log(this.BaseUrl + "/adddata");
    
    return this.http.post(this.BaseUrl + "/adddata", member);
  }
}
