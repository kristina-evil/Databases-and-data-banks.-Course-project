import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Material } from '../models/material.interface';
import { RequestBuilder } from './request-builder';

const apiController = 'Materials';

@Injectable({
  providedIn: 'root',
})
export class MaterialsDataService {
  constructor(private readonly builder: RequestBuilder) {}

  public getMaterialsList(): Observable<Material[]> {
    return this.builder.useApiUrl(`${apiController}/`).get<Material[]>();
  }

  public getMaterialById(id: number): Observable<Material> {
    return this.builder.useApiUrl(`${apiController}/${id}/`).get<Material>();
  }

  public updateMaterial(material: Material) {
    return this.builder.useApiUrl(apiController).put(material);
  }
}
