<template>
    <div style="position: relative">
        <!-- <SpeedDial :model="items" :radius="120" type="quarter-circle" direction="up-right"
            :style="{ left: 0, bottom: 0 }" /> -->

        <button class="toggleButton" @click="toggleSignature">
            <svg width="20px" height="20px" viewBox="0 0 1920 1920" xmlns="http://www.w3.org/2000/svg">
                <g fill="#888888" fill-rule="evenodd" clip-rule="evenodd" stroke="none" stroke-width="1">
                    <path
                        d="M1468.235 113v91.142L822.674 862.89a87.85 87.85 0 0 0-24.598 61.495l-.002 429.859c-.24.366-.477.736-.71 1.109-23.717 42.918-79.058 105.035-112.94 101.647-33.883-3.388-44.048-27.106-72.283-96-36.141-89.224-94.87-206.682-190.87-197.647-120.847 10.165-179.577 225.882-199.906 320.753-6.55 31.188 13.424 61.78 44.611 68.33 31.188 6.549 61.78-13.425 68.33-44.612a484.518 484.518 0 0 1 97.13-225.883s30.493 10.165 77.929 127.624c47.435 117.459 99.388 161.506 169.411 166.023h9.036c112.94 0 196.517-143.435 205.553-160.376 10.037-16.097 10.996-35.285 4.266-51.575h339.697a87.85 87.85 0 0 0 61.496-26.355l169.411-172.872v642.708H0V113h1468.235Zm-903.53 564.706H225.883v112.941h338.824V677.706Zm225.883-225.882H225.882v112.94h564.706v-112.94Z" />
                    <path
                        d="m1903.059 468.765-225.883-225.883a56.47 56.47 0 0 0-80.188 0L919.341 920.53a56.476 56.476 0 0 0-15.813 39.53v282.353h282.354a56.47 56.47 0 0 0 39.53-16.941l677.647-677.647c21.523-21.959 21.523-57.101 0-79.06Zm-208.941 128.753-145.694-145.694 89.223-89.224 145.694 145.694-89.223 89.224Z" />
                </g>
            </svg>
        </button>
        <VuePDF :pdf="pdf" :scale="scale" :page="page" style="margin-bottom: 10px" :fit-parent="fitParent">
            <div class="spinner-grow m-0 9-0" style="width: 100%; height: 100%" role="status">
                <span class="sr-only m-0 p-0">Loading...</span>
            </div>
        </VuePDF>
        <Signaturepdf @refresh-annotation="refreshAnnotation" :source="src" :page="page" v-if="showSignature"
            style="position: absolute; left: 0; top: 0; width: 100%; height: 100%" />
    </div>
</template>

<script setup>
// import SpeedDial from "primevue/speeddial";

import Signaturepdf from "./Signaturepdf.vue";
import { VuePDF } from "@tato30/vue-pdf";
import { ref, defineProps } from "vue";
defineProps(["pdf", "src", "scale", "page", "fitParent"]);
const showSignature = ref(false);
const toggleSignature = () => {
    showSignature.value = !showSignature.value;
};
const emit = defineEmits(["refresh-annotation"]);

const refreshAnnotation = () => {
    emit("refresh-annotation");
};
// const items = ref([
//     {
//         label: 'Add',
//         icon: 'fas fa-pencil-alt',
//         command: () => {

//         },
//     },
//     {
//         label: 'Update',
//         icon: 'fas fa-redo-alt',
//         command: () => {

//         },
//     },
//     {
//         label: 'Delete',
//         icon: 'fa fa-trash',
//         command: () => {

//         },
//     },
//     {
//         label: 'Upload',
//         icon: 'fas fa-upload',
//         command: () => {

//         }
//     },
//     {
//         label: 'Vue Website',
//         icon: 'pi pi-external-link',
//         command: () => {

//         }
//     }
// ])
</script>

<style lang="scss" scoped>
.toggleButton {
    background: #f9f9fb00;
    color: #585858;
    padding: 0px;
    width: auto;
    cursor: pointer;
    border: none;
    position: absolute;
    top: 8px;
    left: 8px;
    z-index: 100;
}
</style>
