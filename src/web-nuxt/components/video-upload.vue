<template>
  <v-dialog
    :value="active" persistent
    max-width="400"
  >
    <v-card>
      <v-card-title class="headline grey lighten-2">
        Privacy Policy
      </v-card-title>
      <v-card-text>
        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
        incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud
        exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute
        irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla
        pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui
        officia deserunt mollit anim id est laborum.
      </v-card-text>
      <v-divider></v-divider>
      <v-card-actions>
        <v-spacer></v-spacer>
        <v-btn
          color="primary"
          text
          @click="toggleActivity"
        >
          I accept
        </v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script>
  import {mapState, mapMutations} from 'vuex';

  export default {
    name: "video-upload",
    data: () => ({}),
    computed: {
      ...mapState('video-upload', ['active']),
    },
    methods: {
      ...mapMutations('video-upload', ['reset', 'toggleActivity'])
    }
  }
</script>

<style scoped>

</style>
