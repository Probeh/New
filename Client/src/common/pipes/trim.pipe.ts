import { Pipe, PipeTransform } from '@angular/core';

@Pipe({ name: 'trim' })
export class TrimPipe implements PipeTransform {

  transform(value: string, args?: number): any {
    return value.length > args ? value.substr(0, args) + '..' : value;
  }

}
