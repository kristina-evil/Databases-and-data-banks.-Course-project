import { Component, OnInit } from '@angular/core';
import { MaterialsDataService } from 'src/app/services/materials.service';

import { Material } from '../../models/material.interface';

@Component({
  selector: 'kks-materials-page',
  templateUrl: './materials-page.component.html',
  styleUrls: ['./materials-page.component.scss'],
})
export class MaterialsPageComponent implements OnInit {
  materials: Material[];

  constructor(private materialsService: MaterialsDataService) {}

  ngOnInit(): void {
    this.getMaterials();
  }

  getMaterials(): void {
    this.materialsService
      .getMaterialsList()
      .subscribe((materials) => (this.materials = materials));
  }
}
