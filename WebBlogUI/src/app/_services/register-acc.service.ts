import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Member } from '../_models/Member';

@Injectable({
  providedIn: 'root'
})
export class RegisterAccService {

  private BaseUrl = environment.baseUrl + '/api/registeracc';

  constructor(private http: HttpClient) { }

  //method
  insertProfileAcc(member : Member) {
    return this.http.post(this.BaseUrl + "/insertproacc", member)
  }
}
