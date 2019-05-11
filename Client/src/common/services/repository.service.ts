import { Injectable, EventEmitter } from '@angular/core';
import { Model } from '../models/core/model';
import { Company } from '../models/company';
import { Software } from '../models/software';
import { Service } from '../models/service';
import { Product } from '../models/product';
import { Solution } from '../models/solution';

@Injectable()
export class RepositoryService {
  // Properties
  public contextListener: EventEmitter<IDataSet>;
  // public updateList: EventEmitter<IDataPair>;
  // public updateModel: EventEmitter<IDataPair>;

  private context: IDataSet = {
    'Companies': new Array<Company>(),
    'Software': new Array<Software>(),
    'Products': new Array<Product>(),
    'Services': new Array<Service>(),
    'Solutions': new Array<Solution>(),
  };

  // Constructor
  constructor() {
    this.contextListener = new EventEmitter<IDataSet>();
    // this.updateList = new EventEmitter<IDataPair>();
    // this.updateModel = new EventEmitter<IDataPair>();

    // this.updateList.subscribe(data => this.onUpdateList(data)).add(() => this.contextListener.emit(this.context));
    // this.updateModel.subscribe(data => this.onUpdateList(data)).add(() => this.contextListener.emit(this.context));
  }

  public async getItem<T extends Model<T>>(dataSet: string, filter?: (value: T, index: number, array: T[]) => any, thisArg?: any): Promise<T> {
    return await new Promise<T>(async (resolve, reject) => {
      resolve(this.context[dataSet].find(filter) as T);
    });
  }
  public async getItems<T extends Model<T>>(dataSet: string, filter?: (value: T, index: number, array: T[]) => any, thisArg?: any): Promise<T[]> {
    return await new Promise<T[]>(async (resolve, reject) => {
      resolve(filter ? this.context[dataSet].filter(filter).slice() as T[] : this.context[dataSet].slice() as T[]);
    });
  }

  // private onUpdateList(value: IDataPair) {
  // (value.data as Model<any>[]).forEach((item: Model<any>) => this.onUpdateItem({ dataSet: value.dataSet, data: item }));
  // }
  // private onUpdateItem(value?: IDataPair) {
  // this.context[value.dataSet].find(x => x.id == (value.data as Model<any>).id)
  //   ? this.context[value.dataSet][this.context[value.dataSet].findIndex(x => x.id == (value.data as Model<any>).id)] = (value.data as Model<any>)
  //   : this.context[value.dataSet].unshift((value.data as Model<any>));
  // }
}
export interface IDataSet {
  [key: string]: Model<any>[];
}
// export interface IDataPair {
//   dataSet: string;
//   data: Model<any> | Model<any>[]
// }