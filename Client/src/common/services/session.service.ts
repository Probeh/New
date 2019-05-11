import { Injectable, OnInit, EventEmitter } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RepositoryService, IDataSet } from './repository.service';
import { Model } from '../models/core/model';
import { map } from 'rxjs/operators';

@Injectable()
export class SessionService {
  public sessionListener: EventEmitter<IDataSet>;

  constructor(private http: HttpClient, private repository: RepositoryService) {
    this.sessionListener = new EventEmitter<IDataSet>();
    this.repository.contextListener
    .subscribe((value: IDataSet) => this.sessionListener.emit(value));
  }

  // HttpGet
  public async getModel<T extends Model<T>>(controller: string, filter?: (value: T, index: number, array: T[]) => any, thisArg?: any): Promise<T> {
    return new Promise<T>(async (resolve, reject) => {
      await this.repository.getItem(controller, filter)
        .then(async (result: T) => {
          result ? resolve(result)
            : await this.http.get(controller)
              .pipe(map(result => { 
                return result as T; 
              }))
              .toPromise().then((result: T) => resolve(result));
        });
    });
  }
  // HttpGet
  public async getModels<T extends Model<T>>(controller: string, filter?: (value: T, index: number, array: T[]) => any, thisArg?: any): Promise<T[]> {
    return new Promise<T[]>(async (resolve, reject) => {
      await this.repository.getItems(controller, filter)
        .then(async (result: T[]) => {
          result && result.length > 0 ? resolve(result)
            : await this.http.get(controller)
              .pipe(map(result => {
                return result as T[];
              }))
              .toPromise().then((result: T[]) => resolve(result));
        });
    });
  }
}