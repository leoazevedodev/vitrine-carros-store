import { AuthService } from './../auth/login/services/auth.service';
import { AuthGuard } from './../auth/login/helpers/auth.guard';
import { CanActivate, Router } from '@angular/router';
import { Component, OnInit, OnDestroy, ViewChild } from '@angular/core';
import { MenuItem, MessageService, PrimeNGConfig, SelectItem } from 'primeng/api';
import { Subscription } from 'rxjs';
import { LayoutService } from 'src/app/layout/service/app.layout.service';
import { DialogService, DynamicDialogRef } from 'primeng/dynamicdialog';
import { Table } from 'primeng/table';
import { Console } from 'console';
import { ProductService } from './productservice';
import { Product } from './products';

@Component({
    templateUrl: './dashboard.component.html',
    styleUrls: ['./dashboard.component.scss'],
    providers: [DialogService, MessageService]
})
export class DashboardComponent implements OnInit {
    
    products: Product[] = [];
    sortOptions: SelectItem[] = [];
    model: any[] = [];

    constructor(private productService: ProductService,
                public layoutService: LayoutService,
                public messageService: MessageService,
                public dialogService: DialogService,
                private AuthService: AuthService,
                private router: Router,
                private primengConfig: PrimeNGConfig)
                 {
    }

    ngOnInit() {
        this.productService.getProducts().then(data => this.products = data);

        this.sortOptions = [
            {label: 'Price High to Low', value: '!price'},
            {label: 'Price Low to High', value: 'price'}
        ];

        this.primengConfig.ripple = true;
    }

}
